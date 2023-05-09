using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_system
{
    internal class Database
    {
        private string _connectionString;
        private SqlConnection _connection;
        private SqlCommand _command;
        private DataTable _dataTable;
        private SqlDataAdapter _dataAdapter;

        public Database()
        {
            _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\srv\SqlDatabaseFiles\DispensaryManagementSystem_DotNET_DB.mdf;Integrated Security=True;Connect Timeout=30";
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
            _command.Connection = _connection;
        }

        public DataTable GetData(string query)
        {
            _dataTable = new DataTable();
            _dataAdapter = new SqlDataAdapter(query, _connectionString);
            _dataAdapter.Fill(_dataTable);
            return _dataTable;
        }

        public int SetData(string query)
        {
            int cnt;
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            _command.CommandText = query;
            cnt = _command.ExecuteNonQuery();

            return cnt;
        }
    }
}
