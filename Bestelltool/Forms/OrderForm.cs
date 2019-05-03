using Bestelltool.Interfaces;
using Bestelltool.Structs;
using System;
using System.Windows.Forms;

namespace Bestelltool
{
    public partial class OrderForm : Form
    {
        private readonly Product old;
        private readonly bool change;
        private string _productname;
        private readonly ICart _w;
        public Product P;

        public OrderForm(string productname, ICart w)
        {
            InitializeComponent();
            _productname = productname;
            _w = w;
            change = false;
        }

        #region Zur Bewegung des Fensters

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        #endregion Zur Bewegung des Fensters

        public OrderForm(Product p, ICart w)         //Konstruktor zum ändern eines Produktes
        {
            InitializeComponent();
            change = true;
            _productname = p.Name;
            old = p;
            _w = w;
            trackBar_ammount.Value = p.Ammount;
            textBox_costcentre.Text = p.Costcentre;
            richTextBox_notice.Text = p.Annotation;
            label_number.Text = p.Ammount.ToString();
        }

        private void Order_Load(object sender, EventArgs e)
        {
        }

        private void trackBar_ammount_Scroll(object sender, EventArgs e)
        {
            label_number.Text = trackBar_ammount.Value.ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_costcentre.Text == string.Empty)
            {
                label_costcentre.ForeColor = System.Drawing.Color.Red;
                return;
            }
            P.Annotation = richTextBox_notice.Text;
            P.Ammount = trackBar_ammount.Value;
            P.Costcentre = textBox_costcentre.Text;
            P.Name = _productname;
            if (change)                 //Wenn Produkt geändert werden soll wird erst die alte Version gelöscht
            {
                _w.Remove(old);
            }
            _w.Add(P);
            Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void textBox_costcentre_TextChanged(object sender, EventArgs e)
        {
            label_costcentre.ForeColor = System.Drawing.Color.Black;
        }
    }
}