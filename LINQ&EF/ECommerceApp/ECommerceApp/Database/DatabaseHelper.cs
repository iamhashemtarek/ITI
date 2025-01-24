using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;

namespace ECommerceApp.Database
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper()
        {
            // Read the connection string from appsettings.json
            _connectionString = Program.Configuration.GetConnectionString("ECommerceDb");

            // Ensure the connection string is not null or empty
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Connection string 'ECommerceDb' is not configured.");
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open(); // Ensure this line is reached
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to execute query: " + ex.Message, ex);
                }
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open(); // Ensure this line is reached
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        return cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to execute non-query: " + ex.Message, ex);
                }
            }
        }
    }
}