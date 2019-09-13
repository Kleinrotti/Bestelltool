using Bestelltool.Classes;
using Bestelltool.Enums;
using Bestelltool.Language;
using Bestelltool.Properties;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Bestelltool
{
     internal class Configuration : IDisposable
     {
          public static string BestellblattPfad { get; private set; } = Settings.Default.Bestellblatt;

          public static string WarenlistenPfad { get; private set; } = Settings.Default.Warenliste;

          private static LangID _defaultLanguage { get; set; } = LangID.German;

          private RegistryKey _registryKey;

          public void ChangePath(OpenFileDialog o, ConfigType configtype)
          {
               if (o.ShowDialog() != DialogResult.Cancel)
               {
                    _registryKey = Registry.CurrentUser.OpenSubKey("Software\\Bestellsoftware", true);
                    _registryKey.SetValue(configtype.ToString(), o.FileName);

                    _registryKey.Close();
               }

               if (configtype == ConfigType.Bestellblattpfad)
               {
                    BestellblattPfad = o.FileName;
               }
               else
               {
                    WarenlistenPfad = o.FileName;
               }
          }

          /// <summary>
          /// Set default filepaths in registry
          /// </summary>
          public void SetStandartPaths()
          {
               _registryKey = Registry.CurrentUser.OpenSubKey("Software", true);

               _registryKey.CreateSubKey("Bestellsoftware");
               _registryKey = _registryKey.OpenSubKey("Bestellsoftware", true);

               if (_registryKey.GetValue("Bestellblattpfad") == null)
               {
                    _registryKey.SetValue("Bestellblattpfad", BestellblattPfad);
               }
               if (_registryKey.GetValue("Warenlistenpfad") == null)
               {
                    _registryKey.SetValue("Warenlistenpfad", WarenlistenPfad);
               }
               if (_registryKey.GetValue("Language") == null)
               {
                    _registryKey.SetValue("Language", _defaultLanguage, RegistryValueKind.DWord);
               }
               BestellblattPfad = _registryKey.GetValue("Bestellblattpfad").ToString();
               WarenlistenPfad = _registryKey.GetValue("Warenlistenpfad").ToString();
               _registryKey.Close();
          }

          /// <summary>
          /// Check if mailpassword exists in registry
          /// </summary>
          /// <returns></returns>
          public bool CheckPasswordExists()
          {
               RegistryKey pswd = Registry.CurrentUser.OpenSubKey("Software", true);
               pswd?.CreateSubKey("Bestellsoftware");
               pswd = pswd?.OpenSubKey("Bestellsoftware");
               if (pswd?.GetValue("Passwort") == null)
               {
                    pswd?.Close();
                    return false;
               }
               pswd.Close();
               return true;
          }

          /// <summary>
          /// Get mailpassword from registry entry
          /// </summary>
          /// <param name="c"></param>
          /// <returns></returns>
          public static string GetRegistryPassword(Credentials c)
          {
               using (RegistryKey k = Registry.CurrentUser.OpenSubKey("Software")?.OpenSubKey("Bestellsoftware"))
               {
                    return Crypting.DecryptString(k.GetValue("Passwort").ToString(), SecureStringHandler.SecureStringToString(c.Password));                   //Rückgabe des entschlüsselten Passworts
               }
          }

          /// <summary>
          /// Save mailpassword encrypted in registry
          /// </summary>
          /// <param name="mailpswd"></param>
          /// <param name="pswd"></param>
          public void WritePasswortRegistry(string mailpswd, string pswd)
          {
               RegistryKey ps = Registry.CurrentUser.OpenSubKey("Software", true);
               ps.CreateSubKey("Bestellsoftware");
               ps = ps.OpenSubKey("Bestellsoftware", true);
               //Mail Passwort wird mit dem Benutzerpasswort verschlüsselt und in der Registry gespeichert
               ps.SetValue("Passwort", Crypting.EncryptString(mailpswd, pswd));
               ps.Close();
          }

          public void Dispose()
          {
               _registryKey.Dispose();
          }
     }
}