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
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "SELECT id, name FROM places WHERE id=" + id + ";";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);

                Place place = new Place();
                DataRow dataRow = dataTable.Rows[0];
                place.Id = dataRow.Field<long>("id");
                place.Name = dataRow.Field<string>("name");
                return place;
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

        public void Delete(Place place)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "DELETE FROM places WHERE id=" + place.Id + ";";
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

        public void Update(Place place)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "UPDATE places SET name='" + place.Name + "' WHERE id=" + place.Id + ";";
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

        public void Insert(Place place)
        {
            MySqlConnection connection = Connection.Connection.GetConnection();
            try
            {
                string sql = "INSERT INTO places(name) VALUES('" + place.Name + "');";
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