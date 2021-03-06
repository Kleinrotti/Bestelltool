﻿using Bestelltool.Classes;
using Bestelltool.Language;
using Bestelltool.Properties;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestelltool
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        #region Zur Bewegung des Fensters

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        #endregion Zur Bewegung des Fensters

        private void LoadingScreen()
        {
            textBox_password.Visible = false;
            textBox_username.Visible = false;
            label_password.Visible = false;
            label_username.Visible = false;
            label_title.Visible = false;

            button_enter.Visible = false;
            pictureBox_loading.Location = new System.Drawing.Point(163, 161);
            pictureBox_loading.Visible = true;
            label_loading.Visible = true;
        }

        private void InputScreen()
        {
            pictureBox_loading.Visible = false;
            textBox_password.Visible = true;
            textBox_username.Visible = true;
            label_password.Visible = true;
            label_username.Visible = true;
            label_title.Visible = true;
            label_loading.Visible = false;
            button_enter.Visible = true;
            textBox_username.Text = Environment.UserName;
            this.SelectNextControl(textBox_username, true, false, false, false);
        }

        private async void button_enter_Click(object sender, EventArgs e)
        {
            Credentials cred = new Credentials
            {
                Username = textBox_username.Text,
                Domain = Settings.Default.WindowsDomain,
            };
            SecureStringHandler.StringToSecureString(ref cred.Password, textBox_password.Text);

            textBox_password.Text = "";
            DomainAuthentification d = new DomainAuthentification(this.Controls);

            LoadingScreen();

            await Task.Factory.StartNew(() =>
            {
                d.IsValid(cred);
            });
            if (d.Valid)
            {
                await d.PasswordInRegistry(cred);
                SqlOperations sql = new SqlOperations(new SqlConnectionStringBuilder()
                { DataSource = "127.0.0.1\\BESTELLSOFTWARE", IntegratedSecurity = true, InitialCatalog = "bestellsoftware" }.ToString());
                MessageBox.Show(sql.Authenticate.ToString());
                Hide();
                UI u = new UI(cred);
                u.ShowDialog();
                Close();
            }
            else
            {
                InputScreen();
                MessageBox.Show(Lang.GetText("message_authentification_wrongcredentials"));
            }
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            Configuration c = new Configuration();
            c.SetStandartPaths();
            Lang lang = new Lang();
            Lang.LanguageChanged += UpdateLangUI;
            LoadTranslation();
            InputScreen();
        }

        private void UpdateLangUI(object sender, EventArgs e)
        {
            LoadTranslation();
        }

        private void LoadTranslation()
        {
            label_loading.Text = Lang.GetText("control_authentification_label_loading");
            label_password.Text = Lang.GetText("control_authentification_label_password");
            label_username.Text = Lang.GetText("control_authentification_label_username");
            label_title.Text = Lang.GetText("control_authentification_label_title");
            button_enter.Text = Lang.GetText("control_authentification_button_enter");
        }

        private void Authentification_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.Enter:
                    button_enter.PerformClick();
                    break;

                case (char)Keys.Escape:
                    Close();
                    break;
            }
        }

        private void Authentification_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}