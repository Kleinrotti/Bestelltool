using Bestelltool.Classes;
using Bestelltool.Enums;
using Bestelltool.Interfaces;
using Bestelltool.Properties;
using Bestelltool.Structs;
using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.String;

namespace Bestelltool
{
    public partial class UI : Form
    {
        private readonly Credentials _login;
        private Goodslist _wl;
        private ICart _w;
        private CompletedOrders _c;
        private Mail _m;
        private Orders _watcher;
        private DateTime _lasthistoryupdate;
        private DateTime _lastproductupdate;

        #region Zur Bewegung des Fensters

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        #endregion Zur Bewegung des Fensters

        public UI(Credentials c)
        {
            InitializeComponent();
            menuStrip1.Renderer = new myRenderer();
            label_user.Text = DomainAuthentification.FullUsername;
            listView_warenkorb.FullRowSelect = true;
            _login = c;
            var k = new Configuration();
            k.SetStandartPaths();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void UI_Load(object sender, EventArgs e)
        {
            _w = new Cart();
            _c = new CompletedOrders();
            button_ordersite.ForeColor = Color.FromArgb(43, 87, 154);
            button_ordersite.BackColor = Color.FromArgb(243, 243, 243);
            LoadProducts();
            fileSystemWatcher_orderhistory.Path = Path.GetDirectoryName(Configuration.BestellblattPfad);
            fileSystemWatcher_orderhistory.Filter = Path.GetFileName(Configuration.BestellblattPfad);

            fileSystemWatcher_products.Path = Path.GetDirectoryName(Configuration.WarenlistenPfad);
            fileSystemWatcher_products.Filter = Path.GetFileName(Configuration.WarenlistenPfad);

            _watcher = new Orders();
            label_lastorderinfo.Text = _watcher.LastOrder;
            _lasthistoryupdate = DateTime.Now;
            _lastproductupdate = DateTime.Now;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            LoadProducts();

            label_searchfor.Text = @"Keine Suche";
        }

        private async void button_order_Click(object sender, EventArgs e)
        {
            if (listView_warenkorb.Items.Count > 0)                                     //Wenn mindestens ein Item im Warenkorb sind kann Bestellt werden
            {
                string mail;
                if (radioButton_defaultmail.Checked)
                {
                    mail = Settings.Default.Mail;
                }
                else
                {
                    mail = textBox_othermail.Text;
                }
                Orders b = new Orders();
                //Letzte Bestellnummer aus der Liste lesen
                int lastId = b.Bestellblatt[b.Bestellblatt.Count - 1].Number + 1;
                _m = new Mail(mail);

                MailStructure str = new MailStructure
                {
                    Ordernumber = lastId,
                    Body = Orders.BuildMail(_w, GetLocation()),
                    Location = GetLocation(),
                    MailPassword = Configuration.GetRegistryPassword(_login)
                };
                pictureBox_bottom.Enabled = true;
                pictureBox_bottom.Visible = true;

                await Task.Factory.StartNew(() =>
                {
                    _m.Send(str);
                });

                if (_m.Sent)
                {
                    b.WriteOrdersToFile(_w, lastId);
                    _w = new Cart();
                    UpdateGoodslist();
                }

                pictureBox_bottom.Visible = false;
                pictureBox_bottom.Enabled = false;
            }
        }

        private string GetLocation()
        {
            if (radioButton_location2.Checked)
            {
                return radioButton_location2.Text;
            }

            return radioButton_location1.Text;
        }

        private void LoadProducts()
        {
            _wl = new Goodslist();
            listView_items.Items.Clear();
            int ammount = 0;

            for (int i = 0; i < _wl.FileContent.Count; i++)
            {
                if (_wl.FileContent[i] != Empty)
                {
                    listView_items.Items.Add(_wl.FileContent[i]);
                    ammount++;
                }
            }

            label_productammount.Text = ammount.ToString();
            label_productammount.ForeColor = Color.Black;
            label_productammount.Location = new Point(373, 563);
            label_productammount.BringToFront();
        }

        private void UpdateGoodslist()
        {
            listView_warenkorb.Items.Clear();
            foreach (var v in _w.Warenkorb)
            {
                var item1 = new ListViewItem(new[] { v.Ammount.ToString(), v.Name, v.Costcentre, v.Annotation });
                listView_warenkorb.Items.Add(item1);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var search = Interaction.InputBox("Suchen");
            if (search != Empty)
            {
                label_searchfor.Text = @"Suche: " + search;
                listView_items.Items.Clear();
                foreach (var v in _wl.FileContent)
                {
                    if (v.ToLower().Contains(search.ToLower()))
                    {
                        listView_items.Items.Add(v);
                    }
                }
                label_productammount.Text = listView_items.Items.Count.ToString();
            }
        }

        private void listView_items_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenOrderWindow();
        }

        private void OpenOrderWindow()
        {
            try
            {
                OrderForm o = new OrderForm(listView_items.SelectedItems[0].Text, _w);
                o.ShowDialog();
                o.Dispose();
                UpdateGoodslist();
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Ungültige Eingabe");
            }
        }

        private void listView_warenkorb_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Right) != 0)
            {
                contextMenuStrip_warenkorb.Show(MousePosition);
            }
        }

        private void contextMenuStrip_warenkorb_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolStripMenuItem_change)
            {
                OrderForm o = new OrderForm(Product.BuildProduct(listView_warenkorb.SelectedItems[0].SubItems), _w);
                o.ShowDialog();
                UpdateGoodslist();
            }
            else
            {
                _w.Remove(Product.BuildProduct(listView_warenkorb.SelectedItems[0].SubItems));
                UpdateGoodslist();
            }
        }

        private void listView_items_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Right) != 0)
            {
                contextMenuStrip_products.Items[0].Enabled = true;
                contextMenuStrip_products.Items[0].Visible = true;

                contextMenuStrip_products.Items[2].Enabled = true;
                contextMenuStrip_products.Items[2].Visible = true;
                contextMenuStrip_products.Show(MousePosition);
            }
        }

        private void toolStripMenuItem_addwarenkorb_Click(object sender, EventArgs e)
        {
            OpenOrderWindow();
        }

        private void toolStripMenuItem_add_Click(object sender, EventArgs e)
        {
            var add = Interaction.InputBox("Produktname");

            if (add != Empty && add.Length > 0)
            {
                _wl.AddProduct(add);
            }
        }

        #region Pfade ändern

        private void warenlistenpfadÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration wk = new Configuration();
            wk.ChangePath(warenlistenpfaddialog, ConfigType.Warenlistenpfad);
        }

        private void bestelllistenpfadÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration wk = new Configuration();
            wk.ChangePath(bestellblattpfaddialog, ConfigType.Bestellblattpfad);
        }

        #endregion Pfade ändern

        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #region Bewegung des Fensters

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label_headline_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion Bewegung des Fensters

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void listView_warenkorb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OrderForm o = new OrderForm(Product.BuildProduct(listView_warenkorb.SelectedItems[0].SubItems), _w);
            o.ShowDialog();
            UpdateGoodslist();
        }

        #region Zwischen Seite wechseln

        private void button_history_Click(object sender, EventArgs e)
        {
            HistoryUI();
        }

        private void HistoryUI()
        {
            button_history.ForeColor = Color.FromArgb(43, 87, 154);
            button_history.BackColor = Color.FromArgb(243, 243, 243);

            button_ordersite.ForeColor = Color.White;
            button_ordersite.BackColor = Color.FromArgb(43, 87, 154);

            _c.Dock = DockStyle.Bottom;
            this.Controls.Add(_c);
            _c.BringToFront();
            _c.Visible = true;
            _c.Enabled = true;
        }

        private void OrderUI()
        {
            button_ordersite.ForeColor = Color.FromArgb(43, 87, 154);
            button_ordersite.BackColor = Color.FromArgb(243, 243, 243);

            button_history.ForeColor = Color.White;
            button_history.BackColor = Color.FromArgb(43, 87, 154);

            _c.Visible = false;
            _c.Enabled = false;
            _c.SendToBack();
        }

        private void button_ordersite_Click(object sender, EventArgs e)
        {
            OrderUI();
        }

        #endregion Zwischen Seite wechseln

        private void fileSystemWatcher_orderhistory_Changed(object sender, FileSystemEventArgs e)
        {
            if ((_lasthistoryupdate - DateTime.Now).Seconds < -1)
            {
                //Bei änderung wird das Event öfters ausgelöst damit aber nur einmal das Label aktualisiert wird muss 1 Sekunde vergangen sein
                Task.Delay(300).Wait();
                _lasthistoryupdate = DateTime.Now;
                using (var _watcher = new Orders())
                {
                    _watcher.GetOrders();
                    label_lastorderinfo.Text = _watcher.LastOrder;
                }
            }
        }

        private void fileSystemWatcher_products_Changed(object sender, FileSystemEventArgs e)
        {
            if ((_lastproductupdate - DateTime.Now).Seconds < -1)
            {
                label_productammount.Text = "Liste nicht mehr aktuell";
                label_productammount.ForeColor = Color.Red;
                label_productammount.Location = new Point(265, 563);
            }
        }

        private void contextMenuStrip_products_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            contextMenuStrip_products.Items[0].Visible = false;
            contextMenuStrip_products.Items[0].Enabled = false;

            contextMenuStrip_products.Items[2].Enabled = false;
            contextMenuStrip_products.Items[2].Visible = false;
        }

        private void toolStripMenuItem_remove_Click(object sender, EventArgs e)
        {
            if (Apply.ConfirmSend())
            {
                _wl = new Goodslist();
                _wl.RemoveProduct(listView_items.SelectedItems[0].Text);
            }
        }

        private void radioButton_custommail_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton_defaultmail_CheckedChanged(object sender, EventArgs e)
        {
            button_order.Enabled = true;
            if (radioButton_defaultmail.Checked)
            {
                label_mailadresse.Text = "Mail: " + Settings.Default.Mail;
                textBox_othermail.Enabled = false;
            }
            else if (radioButton_custommail.Checked)
            {
                textBox_othermail.Enabled = true;
                label_mailadresse.Text = "Mail: Unten eintragen";
            }
        }

        private void InfoStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }
    }

    #region Menüstrip Farbe

    internal class myRenderer : ToolStripProfessionalRenderer                //Für das menüstrip damit mousehover color festgelegt werden kann
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs myMenu)
        {
            if (!myMenu.Item.Selected)
                base.OnRenderMenuItemBackground(myMenu);
            else
            {
                var brush = new SolidBrush(Color.FromArgb(255, 60, 101, 164));
                Rectangle menuRectangle = new Rectangle(Point.Empty, myMenu.Item.Size);
                myMenu.Graphics.FillRectangle(brush, menuRectangle);
                myMenu.Graphics.DrawRectangle(Pens.Transparent, 1, 0, menuRectangle.Width - 2, menuRectangle.Height - 1);
            }
        }
    }

    #endregion Menüstrip Farbe
}