using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace hltv.WinUI
{
    public class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string GetConnectionString()
        {
            return connectionString;
        }

        public void InsertData(string description, string imagePath)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO News (Description, ImagePath) VALUES (@Description, @ImagePath)";

                connection.Execute(sql, new { Description = description, ImagePath = imagePath });
            }
        }

        public void DeleteData(string description)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM News WHERE Description = @Description";

                connection.Execute(sql, new { Description = description });
            }
        }
    }
}
