using Bestelltool.Classes;
using System;
using System.DirectoryServices.AccountManagement;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestelltool
{
    /// <summary>
    /// Class for authenticating at ActiveDirectory
    /// </summary>
    internal class DomainAuthentification
    {
        private readonly Control.ControlCollection _e;
        private const string _group = "EDV";

        /// <summary>
        /// Sur- and Lastname of the user
        /// </summary>
        public static string FullUsername { get; private set; }

        /// <summary>
        /// Are the given user information valid
        /// </summary>
        public bool Valid
        {
            get; private set;
        }

        public DomainAuthentification(Control.ControlCollection e)
        {
            _e = e;
        }

        /// <summary>
        /// Check if login information are correct
        /// </summary>
        public void IsValid(Credentials credentials)
        {
            try
            {
                using (var p = new PrincipalContext(ContextType.Domain, credentials.Domain))
                {
                    if (!p.ValidateCredentials(credentials.Username, SecureStringHandler.SecureStringToString(credentials.Password),
                        ContextOptions.Sealing | ContextOptions.SecureSocketLayer))                 //Wenn Benutzerdaten falsch sind
                    {
                        Valid = false;
                        return;
                    }

                    Valid = IsGroupValid(credentials, p);                                                                //Wenn Benutzerdaten richtig sind wird die Gruppe überprüft
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Check if user is in a specific group
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        private bool IsGroupValid(Credentials credentials, PrincipalContext ctx)
        {
            var user = UserPrincipal.FindByIdentity(ctx, credentials.Username);
            FullUsername = user.Name;
            using (var group = GroupPrincipal.FindByIdentity(ctx, _group))
            {
                if (user.IsMemberOf(group ?? throw new ArgumentException(Language.Language.GetText("error_authentification_groupnotexists"))))
                {
                    return true;
                }
                throw new ArgumentException(Language.Language.GetText("error_authentification_usernotingroup"));                              //Wenn Nutzer nicht in der Gruppe gefunden wurde
            }
        }

        public static SemaphoreSlim Signal = new SemaphoreSlim(0, 1);

        /// <summary>
        /// Check if the encrypted mail password is already in windows registry
        /// </summary>
        /// <param name="credentials"></param>
        /// <returns></returns>
        public async Task PasswordInRegistry(Credentials credentials)
        {
            Configuration k = new Configuration();
            if (k.CheckPasswordExists())                                                //Prüfen ob verschlüsseltes Passwort in der Registry steht
            {
                return;
            }
            MessageBox.Show(Language.Language.GetText("message_authentification_nomailpassword"));
            InsertMailPassword m = new InsertMailPassword(credentials)
            {
                Visible = true,
                Enabled = true,
                Dock = DockStyle.Bottom
            };                                                                          //Form zur Eingabe des Passworts laden
            _e.Add(m);
            m.BringToFront();
            await Signal.WaitAsync();                                                   //Auf abschluss der Eingabe warten
            m.Dispose();
        }
    }
}