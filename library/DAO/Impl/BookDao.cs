using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using library.Model;
using library.SearchCriteries;
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
                    .Append("pl.name placeName, us.name usageName, b.count_of_pages pageCount ")
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
                    book.PlaceName = dataRow.Field<string>("placeName");
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

        public List<TableBook> GetListByCriteria(BookSearchCriteria criteria)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                StringBuilder sqlBuilder = new StringBuilder();
                sqlBuilder
                    .Append("SELECT b.id id, b.name name, a.name authorName, ")
                    .Append("pl.name placeName, us.name usageName, b.count_of_pages pageCount ")
                    .Append("FROM books b ")
                    .Append("INNER JOIN authors a ON b.author_id=a.id ")
                    .Append("INNER JOIN places pl ON b.place_id=pl.id ")
                    .Append("INNER JOIN usage_categories us ON b.usage_category_id=us.id");

                bool needAndQuery = false;
                StringBuilder criteriaBuilder = new StringBuilder();

                if (!string.IsNullOrEmpty(criteria.Text))
                {
                    criteriaBuilder.Append("(LOWER(b.name) LIKE LOWER('%" + criteria.Text +
                                           "%') OR LOWER(a.name) LIKE LOWER('%" + criteria.Text + "%'))");
                    needAndQuery = true;
                }

                if (criteria.Authors.Count > 0)
                {
                    if (needAndQuery)
                    {
                        criteriaBuilder.Append(" AND ");
                    }
                    needAndQuery = true;
                    string authorsId = "";
                    for (int i = 0; i < criteria.Authors.Count; i++)
                    {
                        Author author = criteria.Authors[i];
                        authorsId += author.Id;
                        if (i != criteria.Authors.Count - 1)
                        {
                            authorsId += ",";
                        }
                    }
                    criteriaBuilder.Append("a.id IN (" + authorsId + ")");
                }

                if (criteria.Publishers.Count > 0)
                {
                    if (needAndQuery)
                    {
                        criteriaBuilder.Append(" AND ");
                    }
                    needAndQuery = true;
                    string publishersId = "";
                    for (int i = 0; i < criteria.Publishers.Count; i++)
                    {
                        Publisher publisher = criteria.Publishers[i];
                        publishersId += publisher.Id;
                        if (i != criteria.Publishers.Count - 1)
                        {
                            publishersId += ",";
                        }
                    }
                    criteriaBuilder.Append("b.publisher_id IN (" + publishersId + ")");
                }

                if (criteria.Places.Count > 0)
                {
                    if (needAndQuery)
                    {
                        criteriaBuilder.Append(" AND ");
                    }
                    needAndQuery = true;
                    string placesId = "";
                    for (int i = 0; i < criteria.Places.Count; i++)
                    {
                        Place place = criteria.Places[i];
                        placesId += place.Id;
                        if (i != criteria.Places.Count - 1)
                        {
                            placesId += ",";
                        }
                    }
                    criteriaBuilder.Append("pl.id IN (" + placesId + ")");
                }

                if (criteria.UsageCategories.Count > 0)
                {
                    if (needAndQuery)
                    {
                        criteriaBuilder.Append(" AND ");
                    }
                    string usageCategoriesId = "";
                    for (int i = 0; i < criteria.UsageCategories.Count; i++)
                    {
                        UsageCategory usageCategory = criteria.UsageCategories[i];
                        usageCategoriesId += usageCategory.Id;
                        if (i != criteria.UsageCategories.Count - 1)
                        {
                            usageCategoriesId += ",";
                        }
                    }
                    criteriaBuilder.Append("us.id IN (" + usageCategoriesId + ")");
                }

                if (!string.IsNullOrEmpty(criteriaBuilder.ToString()))
                {
                    sqlBuilder.Append(" WHERE ")
                        .Append(criteriaBuilder);
                }

                sqlBuilder.Append(";");
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
                    book.PlaceName = dataRow.Field<string>("placeName");
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