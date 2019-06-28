using System;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Bestelltool.Interfaces
{
    internal interface ISqlOperator
    {
        event EventHandler<MySqlInfoMessageEventArgs> SqlInfoHandler;

        event EventHandler<MySqlRowUpdatedEventArgs> SqlRowUpdateHandler;

        Task Connect();

        void Disconnect();

        Task<string> GetSingleItem(string query);

        Task<DataSet> GetCompleteTable(string tablename);
    }
}