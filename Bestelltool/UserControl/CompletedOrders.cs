using Bestelltool.Classes;
using Bestelltool.Language;
using Bestelltool.Structs;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
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
        private DataTableCache _memorycache;

        public CompletedOrders()
        {
            InitializeComponent();
            button_search.Visible = true;
            button_update.Visible = true;
            _dt = new DataTable();
            this._dt.Clear();
            this._dt.Columns.Add(Lang.GetText("control_completedorders_dt_column_id"), typeof(int));
            this._dt.Columns.Add(Lang.GetText("control_completedorders_dt_column_product"));
            this._dt.Columns.Add(Lang.GetText("control_completedorders_dt_column_customer"));
            this._dt.Columns.Add(Lang.GetText("control_completedorders_dt_column_costcentre"));
            this._dt.Columns.Add(Lang.GetText("control_completedorders_dt_column_amount"), typeof(int));
            this._dt.Columns.Add(Lang.GetText("control_completedorders_dt_column_date"), typeof(DateTime));
            button_search.Text = Lang.GetText("control_completedorders_button_search");
            button_update.Text = Lang.GetText("control_completedorders_dt_column_button_update");
            this.dataGridView1.DataSource = this._dt;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 380;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 240;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 140;
            progressBar_loaded.Visible = false;
            this.dataGridView1.CellValueNeeded += new
            DataGridViewCellValueEventHandler(dataGridView1_CellValueNeeded);
        }

        private void dataGridView1_CellValueNeeded(object sender,
        DataGridViewCellValueEventArgs e)
        {
            e.Value = _memorycache.RetrieveElement(e.RowIndex, e.ColumnIndex);
        }

        private void CompletedOrders_Load(object sender, EventArgs e)
        {
            //UpdateList();
            dataGridView1.VirtualMode = true;
            //_memorycache = new DataTableCache(sql, 16);
            //foreach (DataColumn column in sql.Columns)
            //{
            //    dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
            //}
            //dataGridView1.RowCount = sql.RowCount;
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

        private void AddToDataTable(Order b)          //Ein Item in eine neue DataTable Zeile einfügen
        {
            DataRow row = _dt.NewRow();
            row[Lang.GetText("control_completedorders_dt_column_id")] = b.Number;
            row[Lang.GetText("control_completedorders_dt_column_product")] = b.Product;
            row[Lang.GetText("control_completedorders_dt_column_customer")] = b.Buyer;
            row[Lang.GetText("control_completedorders_dt_column_costcentre")] = b.Costcentre;
            row[Lang.GetText("control_completedorders_dt_column_amount")] = b.Ammount;
            row[Lang.GetText("control_completedorders_dt_column_date")] = b.Date;
            _dt.Rows.Add(row);
            progressBar_loaded.PerformStep();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var search = Interaction.InputBox(Lang.GetText("control_completedorders_search"));
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