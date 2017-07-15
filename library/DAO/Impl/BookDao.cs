using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using library.Model;
using MySql.Data.MySqlClient;

namespace library.DAO.Impl
{
    public class BookDao
    {
        public List<TableBook> GetList()
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                StringBuilder sqlBuilder = new StringBuilder();
                sqlBuilder
                    .Append("SELECT b.id id, b.name name, a.name authorName, ")
                    .Append("pl.name publisherName, us.name usageName, b.count_of_pages pageCount ")
                    .Append("FROM books b ")
                    .Append("INNER JOIN authors a ON b.author_id=a.id ")
                    .Append("INNER JOIN places pl ON b.place_id=pl.id ")
                    .Append("INNER JOIN usage_categories us ON b.usage_category_id=us.id")
                    .Append(";");
                String sql = sqlBuilder.ToString();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);
                List<TableBook> books = new List<TableBook>(dataTable.Rows.Count);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TableBook book = new TableBook();
                    book.Id = dataRow.Field<long>("id");
                    book.Name = dataRow.Field<string>("name");
                    book.CountOfPages = dataRow.Field<int>("pageCount");
                    book.AuthorName = dataRow.Field<string>("authorName");
                    book.PlaceName = dataRow.Field<string>("publisherName");
                    book.UsageCategoryName = dataRow.Field<string>("usageName");
                    books.Add(book);
                }
                return books;
            }
            catch
            {
                return new List<TableBook>(0);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public Book GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }

        public void Insert(Book book)
        {
            throw new NotImplementedException();
        }
    }
}