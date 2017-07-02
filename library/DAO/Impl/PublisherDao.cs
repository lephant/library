using System;
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
            throw new NotImplementedException();
        }

        public void Delete(Publisher entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Publisher entity)
        {
            throw new NotImplementedException();
        }
    }
}