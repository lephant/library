using System;
using System.Collections.Generic;
using System.Data;
using library.Model;
using MySql.Data.MySqlClient;

namespace library.DAO.Impl
{
    public class AuthorDao : IDao<Author>
    {
        public List<Author> GetList()
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "SELECT id, name FROM authors;";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);

                List<Author> authors = new List<Author>(dataTable.Rows.Count);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Author author = new Author();
                    author.Id = dataRow.Field<long>("id");
                    author.Name = dataRow.Field<string>("name");
                    authors.Add(author);
                }
                return authors;
            }
            catch
            {
                return new List<Author>(0);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public Author GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}