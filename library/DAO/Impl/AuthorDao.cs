﻿using System;
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
            String sql = "SELECT id, fio FROM authors;";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            List<Author> authors = new List<Author>(dataTable.Rows.Count);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Author author = new Author();
                author.Id = dataRow.Field<long>("id");
                author.Fio = dataRow.Field<string>("fio");
            }
            return authors;
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