using Bestelltool.Classes;
using Bestelltool.Language;
using Bestelltool.Properties;
using Sodium;
using System;
using System.Windows.Forms;

namespace Bestelltool
{
    public partial class InsertMailPassword : UserControl
    {
        private readonly Credentials _c;

        public InsertMailPassword(Credentials c)
        {
            InitializeComponent();
            _c = c;
        }

        private void InsertMailPassword_Load(object sender, EventArgs e)
        {
            label_password.Text = Lang.GetText("control_insertmailpassword_label_password");
            button_ok.Text = Lang.GetText("control_insertmailpassword_button_ok");
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_password.Text == string.Empty)
            {
                return;
            }
            if (PasswordHash.ArgonHashStringVerify(Settings.Default.MailHash, textBox_password.Text))
            {
                Configuration k = new Configuration();
                k.WritePasswortRegistry(textBox_password.Text, SecureStringHandler.SecureStringToString(_c.Password));
                this.Dispose();
                //Signals that input has been finished
                DomainAuthentification.Signal.Release();
            }
            else
            {
                MessageBox.Show(Lang.GetText("message_insertmailpassword_wrongpassword"));
            }
        }

        private void InsertMailPassword_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.Enter:
                    button_ok.PerformClick();
                    break;
            }
        }
    }
}