using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kurs
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-4JG7JH0\SQLEXPRESS; Initial Catalog = Kurs; Integrated Security = True");



        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();

            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
