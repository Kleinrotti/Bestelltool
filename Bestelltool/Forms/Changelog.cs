using System.Windows.Forms;

namespace Bestelltool.Classes
{
    internal class Changelog : Form
    {
        public Changelog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            //
            // Changelog
            //
            this.ClientSize = new System.Drawing.Size(385, 342);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Changelog";
            this.Load += new System.EventHandler(this.Changelog_Load);
            this.ResumeLayout(false);
        }

        private void Changelog_Load(object sender, System.EventArgs e)
        {
        }
    }
}