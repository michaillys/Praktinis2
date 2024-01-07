using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using MySql.Data.MySqlClient;

namespace Praktinis2
{
    public class CreateUnit
    {

        public static void AddUnit(int UnitID, int UnitSize, string UnitName, int PersonID)
        {
            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Insert into unit table
                using (MySqlCommand command = new MySqlCommand("INSERT INTO unit (UnitID, GroupID, UnitSize, UnitName, PersonID) VALUES (@UnitID, 0, @UnitSize, @UnitName, @PersonID)", connection))
                {
                    command.Parameters.AddWithValue("@UnitID", UnitID);
                    command.Parameters.AddWithValue("@UnitSize", UnitSize);
                    command.Parameters.AddWithValue("@UnitName", UnitName);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.ExecuteNonQuery();
                }
                
            }
        }   
    }
}
