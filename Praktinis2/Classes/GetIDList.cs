using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Praktinis2
{
    public class GetIDList
    {
        public static List<int> GetManagerIDList()
        {
            List<int> managerIDList = new List<int>();
            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT ManagerID FROM manager", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            managerIDList.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return managerIDList;
        }

        public static List<int> GetUnitIDList()
        {
            List<int> unitIDList = new List<int>();
            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT UnitID FROM unit", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            unitIDList.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return unitIDList;
        }

        public static List<int> GetGroupIDList()
        {
            List<int> groupIDList = new List<int>();
            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT GroupID FROM `group`", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            groupIDList.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return groupIDList;
        }
    }
}
