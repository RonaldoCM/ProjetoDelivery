﻿using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Data;

namespace DataAccess
{
    public class MySqlDataAccess
    {
        private string connectionString;

        // Constructor that sets the connection string
        public MySqlDataAccess(string server, string database, string username, string password)
        {
            connectionString = $"Server={server};Database={database};User Id={username};Password={password};";
        }

        // Method to execute non-query SQL (Insert, Update, Delete)
        public bool ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            bool result = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }
                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        // Method to retrieve data from database (SELECT)
        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return dataTable;
        }

        public int ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        var result = Convert.ToInt32(cmd.ExecuteScalar());

                        return (result != null && int.TryParse(result.ToString(), out int value)) ? value : 0;

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
        }
    }
}


