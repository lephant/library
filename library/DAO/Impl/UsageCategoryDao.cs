using System;
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
            throw new NotImplementedException();
        }

        public void Delete(UsageCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Update(UsageCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}