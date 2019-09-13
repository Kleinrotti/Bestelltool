using System.Data;

namespace Bestelltool.Interfaces
{
    internal interface IDataPageRetriever
    {
        DataTable SupplyPageOfData(int lowerPageBoundary, int rowsPerPage);
    }
}