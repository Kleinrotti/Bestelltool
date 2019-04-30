using Bestelltool.Interfaces;
using Bestelltool.Structs;
using System.Collections.Generic;

namespace Bestelltool.Classes
{
    /// <summary>
    /// Class for creating and managing a cart
    /// </summary>
    public sealed class Cart : ICart
    {
        /// <summary>
        /// Contains all added products from cart
        /// </summary>
        public List<Product> Warenkorb { get; private set; }

        private Product p;

        public Cart()
        {
            Warenkorb = new List<Product>();
        }

        /// <summary>
        /// Add a product to cart
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ammount"></param>
        /// <param name="annotation"></param>
        /// <param name="costcentre"></param>
        public void Add(string name, int ammount, string annotation, string costcentre)
        {
            p.Ammount = ammount;
            p.Name = name;
            p.Annotation = annotation;
            p.Costcentre = costcentre;
            Warenkorb.Add(p);
        }

        /// <summary>
        /// Add a product to cart
        /// </summary>
        /// <param name="p"></param>
        public void Add(Product p)
        {
            Warenkorb.Add(p);
        }

        /// <summary>
        /// Remove a product from cart
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ammount"></param>
        /// <param name="annotation"></param>
        /// <param name="costcentre"></param>
        public void Remove(string name, int ammount, string annotation, string costcentre)
        {
            p.Ammount = ammount;
            p.Name = name;
            p.Annotation = annotation;
            p.Costcentre = costcentre;
            Warenkorb.Remove(p);
        }

        /// <summary>
        /// Remove a product from cart
        /// </summary>
        /// <param name="p"></param>
        public void Remove(Product p)
        {
            Warenkorb.Remove(p);
        }

        public void Dispose()
        {
            Warenkorb = null;
        }
    }
}