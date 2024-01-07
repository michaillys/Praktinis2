using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace Praktinis2
{
    public class LoginLog
    {
       
        public void LogLogin(int loginID)
        {   

            
            string connectionString = DBConnection.GetConnectionString();
            int entryID = GetLastID.GetLast("loginlog", "EntryID") + 1;
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                
                try
                {                    
                    connection.Open();
                    string query = "INSERT INTO loginlog (entryID, LoginID, DateTime) VALUES (@entryID, @user_id, @login_time);";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@user_id", loginID);
                    cmd.Parameters.AddWithValue("@login_time", DateTime.Now);
                    cmd.Parameters.AddWithValue("@entryID", entryID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User logged in", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        


    }
}
