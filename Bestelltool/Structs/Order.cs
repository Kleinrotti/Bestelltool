using System;

namespace Bestelltool.Structs
{
    public struct Order
    {
        public int Number;
        public string Product;
        public string Buyer;
        public string Costcentre;
        public DateTime Date;
        public int Ammount;
    }
}