﻿using Npgsql;
using Microsoft.EntityFrameworkCore;

namespace AdvertisingAgency.Models
{
    public class DBConect : DbContext
    {
        NpgsqlConnection npgsqlConnection;
        public DBConect(string value)
        {
            npgsqlConnection = new NpgsqlConnection($"User ID={value};Password=Sanyagavr11;Host=localhost;Port=5432;Database=AdvertisingAgency;");
        }
        public void OpenConnection()
        {
            if (npgsqlConnection.State == System.Data.ConnectionState.Closed)
            {
                npgsqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (npgsqlConnection.State == System.Data.ConnectionState.Open)
            {
                npgsqlConnection.Close();
            }
        }
        public NpgsqlConnection getConnection()
        {
            return npgsqlConnection;
        }
    }
}