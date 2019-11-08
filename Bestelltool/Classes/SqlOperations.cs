using Bestelltool.Interfaces;
using Bestelltool.Logger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Bestelltool.Classes
{
    internal class SqlOperations : IDataPageRetriever, ISqlOperator
    {
        private string _tableName;
        private SqlCommand _command;
        private SqlConnection _connection;

        public SqlOperations(string connectionString, string tableName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            _command = connection.CreateCommand();
            this._tableName = tableName;
        }

        public SqlOperations(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public bool Authenticate
        {
            get
            {
                try
                {
                    _connection.Open();
                    _connection.Close();
                    return true;
                }
                catch (SqlException ex)
                {
                    return false;
                }
            }
        }

        private int rowCountValue = -1;

        public int RowCount
        {
            get
            {
                // Return the existing value if it has already been determined.
                if (rowCountValue != -1)
                {
                    return rowCountValue;
                }

                // Retrieve the row count from the database.
                _command.CommandText = "SELECT COUNT(*) FROM " + _tableName;
                rowCountValue = (int)_command.ExecuteScalar();
                return rowCountValue;
            }
        }

        private DataColumnCollection columnsValue;

        public DataColumnCollection Columns
        {
            get
            {
                // Return the existing value if it has already been determined.
                if (columnsValue != null)
                {
                    return columnsValue;
                }

                // Retrieve the column information from the database.
                _command.CommandText = "SELECT * FROM " + _tableName;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = _command;
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.FillSchema(table, SchemaType.Source);
                columnsValue = table.Columns;
                return columnsValue;
            }
        }

        private string commaSeparatedListOfColumnNamesValue = null;

        private string CommaSeparatedListOfColumnNames
        {
            get
            {
                // Return the existing value if it has already been determined.
                if (commaSeparatedListOfColumnNamesValue != null)
                {
                    return commaSeparatedListOfColumnNamesValue;
                }

                // Store a list of column names for use in the
                // SupplyPageOfData method.
                System.Text.StringBuilder commaSeparatedColumnNames =
                    new System.Text.StringBuilder();
                bool firstColumn = true;
                foreach (DataColumn column in Columns)
                {
                    if (!firstColumn)
                    {
                        commaSeparatedColumnNames.Append(", ");
                    }
                    commaSeparatedColumnNames.Append(column.ColumnName);
                    firstColumn = false;
                }

                commaSeparatedListOfColumnNamesValue =
                    commaSeparatedColumnNames.ToString();
                return commaSeparatedListOfColumnNamesValue;
            }
        }

        // Declare variables to be reused by the SupplyPageOfData method.
        private string columnToSortBy;

        private SqlDataAdapter adapter = new SqlDataAdapter();

        public DataTable SupplyPageOfData(int lowerPageBoundary, int rowsPerPage)
        {
            // Store the name of the ID column. This column must contain unique
            // values so the SQL below will work properly.
            if (columnToSortBy == null)
            {
                columnToSortBy = this.Columns[0].ColumnName;
            }

            if (!this.Columns[columnToSortBy].Unique)
            {
                throw new InvalidOperationException(String.Format(
                    "Column {0} must contain unique values.", columnToSortBy));
            }

            // Retrieve the specified number of rows from the database, starting
            // with the row specified by the lowerPageBoundary parameter.
            _command.CommandText = "Select Top " + rowsPerPage + " " +
                CommaSeparatedListOfColumnNames + " From " + _tableName +
                " WHERE " + columnToSortBy + " NOT IN (SELECT TOP " +
                lowerPageBoundary + " " + columnToSortBy + " From " +
                _tableName + " Order By " + columnToSortBy +
                ") Order By " + columnToSortBy;
            adapter.SelectCommand = _command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            return table;
        }

        public Task<List<object>> ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExecuteInsert(string query)
        {
            ILog l = new Log();
            try
            {
                _command.CommandText = query;
                _command.ExecuteNonQueryAsync();
                l.Info("Executed insert query");
                return Task.FromResult(true);
            }
            catch (SqlException ex)
            {
                l.Error(ex.Message);
                return Task.FromResult(false);
            }
        }
    }
}