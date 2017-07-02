using System;
using System.Collections.Generic;
using System.Data;
using library.Model;
using MySql.Data.MySqlClient;

namespace library.DAO.Impl
{
    public class PlaceDao : IDao<Place>
    {
        public List<Place> GetList()
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "SELECT id, name FROM places;";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);

                List<Place> places = new List<Place>(dataTable.Rows.Count);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Place place = new Place();
                    place.Id = dataRow.Field<long>("id");
                    place.Name = dataRow.Field<string>("name");
                    places.Add(place);
                }
                return places;
            }
            catch
            {
                return new List<Place>(0);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public Place GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Place entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Place entity)
        {
            throw new NotImplementedException();
        }
    }
}