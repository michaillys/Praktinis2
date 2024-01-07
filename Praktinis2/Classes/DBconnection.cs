using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Praktinis2
{
    public class DBConnection
    {
        public static string GetConnectionString()
        {            
            string server = "localhost";
            string database = "mic";
            string user = "mic";
            string password = "mic";

            string connectionString = $"Server={server};Database={database};User Id={user};Password={password};";
            return connectionString;
        }
    }
}
    

