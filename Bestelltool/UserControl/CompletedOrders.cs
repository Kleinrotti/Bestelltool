using Bestelltool.Classes;
using Bestelltool.Structs;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestelltool
{
    public partial class CompletedOrders : UserControl
    {
        private readonly DataTable _dt;
        private Orders _b;

        public CompletedOrders()
        {
            InitializeComponent();
            button_search.Visible = true;
            button_update.Visible = true;
            _dt = new DataTable();
            this._dt.Clear();
            this._dt.Columns.Add("ID", typeof(int));
            this._dt.Columns.Add("Produkt");
            this._dt.Columns.Add("Besteller");
            this._dt.Columns.Add("Kostenstelle");
            this._dt.Columns.Add("Menge", typeof(int));
            this._dt.Columns.Add("Datum", typeof(DateTime));
            this.dataGridView1.DataSource = this._dt;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 380;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 240;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 140;
            progressBar_loaded.Visible = false;
        }

        private void CompletedOrders_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private async void UpdateList()
        {
            progressBar_loaded.Visible = true;
            _dt.Clear();
            progressBar_loaded.Value = 0;
            _b = new Orders();
            _b.GetOrders();
            progressBar_loaded.Maximum = _b.Bestellblatt.Count;
            await Task.Factory.StartNew(() =>
            {
                Parallel.ForEach(_b.Bestellblatt, (v) =>
                {
                    Invoke(new MethodInvoker(() => AddToDataTable(v)));
                });
            });
            progressBar_loaded.Visible = false;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void AddToDataTable(Structs.Order b)          //Ein Item in eine neue DataTable Zeile einfügen
        {
            DataRow row = _dt.NewRow();
            row["ID"] = b.Number;
            row["Produkt"] = b.Product;
            row["Besteller"] = b.Buyer;
            row["Kostenstelle"] = b.Costcentre;
            row["Menge"] = b.Ammount;
            row["Datum"] = b.Date;
            _dt.Rows.Add(row);
            progressBar_loaded.PerformStep();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var search = Interaction.InputBox("Suchen");
            if (search != string.Empty && search.Length > 0)
            {
                _dt.Clear();
                progressBar_loaded.Visible = true;
                foreach (Order v in _b.Bestellblatt)
                {
                    if (v.Buyer.ToLower()
                            .Contains(search.ToLower()) || v.Costcentre.ToLower().Contains(search.ToLower()) ||
                                v.Product.ToLower().Contains(search.ToLower()))
                    {
                        AddToDataTable(v);
                    }
                }
                progressBar_loaded.Visible = false;
            }
        }
    }
}