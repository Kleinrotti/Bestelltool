using Bestelltool.Interfaces;
using Bestelltool.Structs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Bestelltool.Classes
{
    internal class Orders : FileOperation, IDisposable
    {
        public List<Order> Bestellblatt;
        private Order _b;

        public void GetOrders()
        {
            int count = 1;
            try
            {
                Bestellblatt = new List<Order>();
                ReadFile(Bestelltool.Configuration.BestellblattPfad);
                foreach (var v in FileContent)
                {
                    int i = 0;
                    foreach (var s in v.Split(';'))
                    {
                        switch (i)
                        {
                            case 0:
                                _b.Number = Convert.ToInt32(s);
                                break;

                            case 1:
                                _b.Product = s;
                                break;

                            case 2:
                                _b.Buyer = s;
                                break;

                            case 3:
                                _b.Date = DateTime.ParseExact(s, "dd.MM.yyyy HH:mm:ss",
                                    System.Globalization.CultureInfo.InvariantCulture);
                                break;

                            case 4:
                                _b.Costcentre = s;
                                break;

                            case 5:
                                _b.Ammount = Convert.ToInt32(s);
                                break;
                        }

                        i++;
                    }
                    Bestellblatt.Add(_b);
                    count++;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Formatierung in Bestellblatt Datei falsch, in Zeile: " + count);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Get the last order
        /// </summary>
        public string LastOrder
        {
            get
            {
                try
                {
                    var lastId = Bestellblatt[Bestellblatt.Count - 1];
                    return lastId.Ammount + "x " + lastId.Product +
                        " am " + lastId.Date + " von " + lastId.Buyer;
                }
                catch (Exception)
                {
                    return "-";
                }
            }
        }

        /// <summary>
        /// Build the mail body text
        /// </summary>
        /// <param name="w"></param>
        /// <param name="hostpital"></param>
        /// <returns></returns>
        public static string BuildMail(ICart w, string location)             //Zusammenbauen des Bodys der Mail mit den Produkten in dem Warenkorb
        {
            string body = "";
            string bottom = "Bestellt von: " + DomainAuthentification.FullUsername +
                "\n\nMit freundlichem Gruss\nEDV " + location;
            const string header = "Hallo,\n\nhiermit bestellen wir folgende Artikel:\n\n";
            foreach (var v in w.Warenkorb)
            {
                body += v.Ammount + "x " + v.Name + "\nKostenstelle: " + v.Costcentre + "\nAnmerkung: " +
                    v.Annotation + "\n--------------------------------------------\n\n";
            }

            var mail = header + body + bottom;
            return mail;
        }

        /// <summary>
        /// Write order to file
        /// </summary>
        /// <param name="w"></param>
        /// <param name="lastId"></param>
        public async void WriteOrdersToFile(ICart w, int lastId)
        {
            foreach (var v in w.Warenkorb)
            {
                var today = DateTime.Now;
                var line = lastId + ";" + v.Name + ";" + DomainAuthentification.FullUsername + ";" +
                              today.ToString("dd.MM.yyyy HH:mm:ss") + ";" + v.Costcentre + ";" + v.Ammount;
                await WriteFile(Bestelltool.Configuration.BestellblattPfad, line);
            }
        }

        public void Dispose()
        {
            Bestellblatt = null;
        }
    }
}