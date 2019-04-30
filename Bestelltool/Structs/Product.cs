using System;
using System.Windows.Forms;

namespace Bestelltool.Structs
{
    public struct Product
    {
        public string Name;
        public string Annotation;
        public int Ammount;
        public string Costcentre;

        public static Product BuildProduct(ListViewItem.ListViewSubItemCollection sub)
        {
            Product _pr = default;
            int i = 0;
            foreach (ListViewItem.ListViewSubItem v in sub)
            {
                switch (i)
                {
                    case 0:
                        _pr.Ammount = Convert.ToInt16(v.Text);
                        break;

                    case 1:
                        _pr.Name = v.Text;
                        break;

                    case 2:
                        _pr.Costcentre = v.Text;
                        break;

                    case 3:
                        _pr.Annotation = v.Text;
                        break;
                }
                i++;
            }
            return _pr;
        }
    }
}