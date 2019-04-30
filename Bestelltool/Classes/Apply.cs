using System.Windows.Forms;

namespace Bestelltool
{
    internal class Apply
    {
        private static DialogResult dialogResult;

        public static bool ConfirmSend()
        {
            dialogResult = MessageBox.Show(@"Bestellung abschicken?", @"Bestätigen", MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    return true;

                case DialogResult.No:
                    return false;
            }
            return false;
        }

        public static bool ConfirmRemoval()
        {
            dialogResult = MessageBox.Show(@"Produkt dauerhaft aus der Liste entfernen?", @"Bestätigen", MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    return true;

                case DialogResult.No:
                    return false;
            }

            return false;
        }
    }
}