using Bestelltool.Interfaces;
using System;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Bestelltool.Classes
{
    internal class SqlOperations : ISqlOperator
    {
        private MySqlConnection _con;
        private MySqlConnectionStringBuilder _constring;
        public event EventHandler<MySqlInfoMessageEventArgs> SqlInfoHandler;
        public event EventHandler<MySqlRowUpdatedEventArgs> SqlRowUpdateHandler;

        public SqlOperations(MySqlConnectionStringBuilder information)
        {
            _constring = information;
            _con = new MySqlConnection(_constring.ConnectionString);
        }

        public async Task Connect()
        {
            await _con.OpenAsync();
        }

        public void Disconnect()
        {
            _con.Close();
        }

        public async Task<DataSet> GetCompleteTable(string tablename)
        {
            var command = new MySqlCommand($"SELECT * FROM {tablename}",_con);
            var v = new MySqlDataAdapter(command);
            var set = new DataSet();
            await v.FillAsync(set).ConfigureAwait(true);
            return set;
        }

        public Task<string> GetSingleItem(string query)
        {
            throw new NotImplementedException();
        }
    }
}