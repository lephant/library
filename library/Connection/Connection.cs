using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace library.Connection
{
    public class Connection
    {
        private static MySqlConnection _sqlConnection;

        private Connection()
        {
        }

        public static MySqlConnection GetConnection()
        {
            if (_sqlConnection == null)
            {
                _sqlConnection = new MySqlConnection();
            }
            return _sqlConnection;
        }
    }
}
