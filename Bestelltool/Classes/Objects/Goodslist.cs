using System;
using System.Windows.Forms;

namespace Bestelltool.Classes
{
    /// <summary>
    /// Class to manage products
    /// </summary>
    internal class Goodslist : FileOperation
    {
        public Goodslist()
        {
            try
            {
                ReadFile(Bestelltool.Configuration.WarenlistenPfad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Add a new product to file
        /// </summary>
        /// <param name="product"></param>
        public async void AddProduct(string product)
        {
            await WriteFile(Bestelltool.Configuration.WarenlistenPfad, product);
        }

        /// <summary>
        /// Remove a product from file
        /// </summary>
        /// <param name="product"></param>
        public void RemoveProduct(string product)
        {
            try
            {
                this.Remove(Bestelltool.Configuration.WarenlistenPfad, product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}