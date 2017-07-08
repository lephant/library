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
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "SELECT id, name FROM authors WHERE id=" + id + ";";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);

                Author author = new Author();
                DataRow dataRow = dataTable.Rows[0];
                author.Id = dataRow.Field<long>("id");
                author.Name = dataRow.Field<string>("name");
                return author;
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

        public void Delete(Author author)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "DELETE FROM authors WHERE id=" + author.Id + ";";
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

        public void Update(Author author)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "UPDATE authors SET name=" + author.Name + " WHERE id=" + author.Id + ";";
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

        public void Insert(Author author)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "INSERT INTO authors(name) VALUES(" + author.Name + ");";
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