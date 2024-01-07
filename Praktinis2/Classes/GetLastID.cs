using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Praktinis2
{
    public class GetLastID : DBConnection
    {
        public static int GetLast(string table, string column)
        {
            int lastID;
            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Get the last ID from the table
                using (MySqlCommand command = new MySqlCommand($"SELECT MAX({column}) FROM `{table}`", connection))
                {
                    lastID = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return lastID;
        }
    }
}
