using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using MySql.Data.MySqlClient;

namespace Praktinis2
{
    public class AddNewManager
    {
        public static void AddManager(string firstName, string lastName, int roleID, int login)
        {
            int managerID = GetLastID.GetLast("manager", "ManagerID") + 1;
            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //Insert into login table
                using (MySqlCommand loginCommand = new MySqlCommand("INSERT INTO login (Login, Username, Password) VALUES (@loginID, @userName, @password)", connection))
                {
                    loginCommand.Parameters.AddWithValue("@loginID", login);
                    loginCommand.Parameters.AddWithValue("@userName", firstName);
                    loginCommand.Parameters.AddWithValue("@password", lastName);
                    loginCommand.ExecuteNonQuery();
                }

                //Insert into manager table
                using (MySqlCommand managerCommand = new MySqlCommand("INSERT INTO manager (ManagerID, FirstName, LastName, RoleID, Login) VALUES (@managerID, @firstName, @lastName, @roleID, @loginID)", connection))
                {
                    managerCommand.Parameters.AddWithValue("@managerID", managerID);
                    managerCommand.Parameters.AddWithValue("@firstName", firstName);
                    managerCommand.Parameters.AddWithValue("@lastName", lastName);
                    managerCommand.Parameters.AddWithValue("@roleID", roleID);
                    managerCommand.Parameters.AddWithValue("@loginID", login);
                    managerCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
