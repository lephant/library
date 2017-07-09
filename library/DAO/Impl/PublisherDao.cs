using System.Collections.Generic;
using System.Data;
using library.Model;
using MySql.Data.MySqlClient;

namespace library.DAO.Impl
{
    public class PublisherDao : IDao<Publisher>
    {
        public List<Publisher> GetList()
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "SELECT id, name FROM publishers;";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);

                List<Publisher> publishers = new List<Publisher>(dataTable.Rows.Count);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Publisher publisher = new Publisher();
                    publisher.Id = dataRow.Field<long>("id");
                    publisher.Name = dataRow.Field<string>("name");
                    publishers.Add(publisher);
                }
                return publishers;
            }
            catch
            {
                return new List<Publisher>(0);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public Publisher GetById(long id)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "SELECT id, name FROM publishers WHERE id=" + id + ";";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);

                Publisher publisher = new Publisher();
                DataRow dataRow = dataTable.Rows[0];
                publisher.Id = dataRow.Field<long>("id");
                publisher.Name = dataRow.Field<string>("name");
                return publisher;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void Delete(Publisher publisher)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "DELETE FROM publishers WHERE id=" + publisher.Id + ";";
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void Update(Publisher publisher)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "UPDATE publishers SET name='" + publisher.Name + "' WHERE id=" + publisher.Id + ";";
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void Insert(Publisher publisher)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "INSERT INTO publishers(name) VALUES('" + publisher.Name + "');";
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}