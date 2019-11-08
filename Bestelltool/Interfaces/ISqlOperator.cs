using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bestelltool.Interfaces
{
    internal interface ISqlOperator
    {
        bool Authenticate { get; }

        Task<List<object>> ExecuteQuery(string query);

        Task<bool> ExecuteInsert(string query);
    }
}