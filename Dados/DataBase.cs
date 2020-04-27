using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class DataBase : IDisposable
    {
        private SqlConnection connection;
        public DataBase()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServerConnection"].ConnectionString);
            connection.Open();
        }

        public void ExecuteCommand(string query)
        {
            var cmd = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text,
                Connection = connection
            };
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader ExecuteCommandWithReturn(string query)
        {
            return new SqlCommand(query, connection).ExecuteReader();
        }

        public void Dispose()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
