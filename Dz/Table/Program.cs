using System;
using System.Data.SqlClient;

namespace ADONET
{
    class Program
    {
        const string connectionString = "Server=A-305-08;Database=Test;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                string query = $"drop table if exists gruppa;" +
                  $"" +
                  $"create table gruppa (" +
                  $"Id bigint Primary Key not null," +
                  $"Name nvarchar(50) not null" +
                  $")";

                command.CommandText = query;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
