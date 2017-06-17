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
                string serverName = "localhost";
                string userName = "user";
                string password = "password";
                string dbName = "library";
                string port = "3306";
                string connStr = "server=" + serverName +
                                 ";user=" + userName +
                                 ";database=" + dbName +
                                 ";port=" + port +
                                 ";password=" + password + ";";
                _sqlConnection = new MySqlConnection(connStr);
            }
            return _sqlConnection;
        }
    }
}