using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUD
{
    public class Connection
    {
        public SqlConnection connection = new SqlConnection();
        public SqlCommand command = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public SqlDataAdapter da = new SqlDataAdapter();
        public string sql = string.Empty;

        public Connection()
        {
            connection.ConnectionString = @"Data Source=OMAEL-PC\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True";
        }

        public SqlConnection connect()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public SqlConnection disconnect()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
