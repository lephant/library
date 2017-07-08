using System.Collections.Generic;
using System.Data;
using library.Model;
using MySql.Data.MySqlClient;

namespace library.DAO.Impl
{
    public class UsageCategoryDao : IDao<UsageCategory>
    {
        public List<UsageCategory> GetList()
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "SELECT id, name FROM usage_categories;";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);

                List<UsageCategory> usageCategories = new List<UsageCategory>(dataTable.Rows.Count);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    UsageCategory usageCategory = new UsageCategory();
                    usageCategory.Id = dataRow.Field<long>("id");
                    usageCategory.Name = dataRow.Field<string>("name");
                    usageCategories.Add(usageCategory);
                }
                return usageCategories;
            }
            catch
            {
                return new List<UsageCategory>(0);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public UsageCategory GetById(long id)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "SELECT id, name FROM usage_categories WHERE id=" + id + ";";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);

                UsageCategory usageCategory = new UsageCategory();
                DataRow dataRow = dataTable.Rows[0];
                usageCategory.Id = dataRow.Field<long>("id");
                usageCategory.Name = dataRow.Field<string>("name");
                return usageCategory;
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

        public void Delete(UsageCategory usageCategory)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "DELETE FROM usage_categories WHERE id=" + usageCategory.Id + ";";
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

        public void Update(UsageCategory usageCategory)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "UPDATE usage_categories SET name=" + usageCategory.Name + " WHERE id=" + usageCategory.Id + ";";
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

        public void Insert(UsageCategory usageCategory)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "INSERT INTO usage_categories(name) VALUES(" + usageCategory.Name + ");";
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