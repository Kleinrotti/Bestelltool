using Bestelltool.Properties;
using Bestelltool.Structs;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Bestelltool
{
    internal class Mail
    {
        private readonly string _mailadress;
        private const string _hostserver = "mailing.company.de";
        private const string _hostserverusername = "mycompany\\orders";
        private const int _port = 25;

        public Mail(string mailadress)
        {
            _mailadress = mailadress;
        }

        public bool Sent { get; private set; }

        public void Send(MailStructure s)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(Settings.Default.HostMail);
                mailMessage.To.Add(_mailadress);
                mailMessage.Subject = "Bestellung: " + s.Ordernumber + " || " + s.Location + " ||";
                MailAddress cc = new MailAddress(Settings.Default.HostMail);
                mailMessage.Body = s.Body;

                SmtpClient smtpClient = new SmtpClient(_hostserver, _port);
                mailMessage.CC.Add(cc);
                smtpClient.Credentials = new NetworkCredential(_hostserverusername, s.MailPassword);

                if (Apply.ConfirmSend())
                {
                    smtpClient.Send(mailMessage);
                    Sent = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Sent = false;
            }
        }
    }
}