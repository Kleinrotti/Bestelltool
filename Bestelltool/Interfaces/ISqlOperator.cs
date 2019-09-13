using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Bestelltool.Interfaces
{
    internal interface ISqlOperator
    {
        bool Authenticate{get;}
        Task<List<object>> ExecuteQuery(string query);
    }
}