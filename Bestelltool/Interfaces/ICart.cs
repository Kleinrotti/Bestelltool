using Bestelltool.Structs;
using System;
using System.Collections.Generic;

namespace Bestelltool.Interfaces
{
    public interface ICart : IDisposable
    {
        List<Product> Warenkorb { get; }

        /// <summary>
        /// Add a product to cart
        /// </summary>
        /// <param name="p"></param>
        void Add(Product p);

        /// <summary>
        /// Remove a product from cart
        /// </summary>
        /// <param name="p"></param>
        void Remove(Product p);
    }
}