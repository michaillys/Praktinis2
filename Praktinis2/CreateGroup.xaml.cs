using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace Praktinis2
{
    /// <summary>
    /// Interaction logic for CreateGroup.xaml
    /// </summary>
    public partial class CreateGroup : Window
    {
        public CreateGroup()
        {
            InitializeComponent();
            int ManagerID;
            //get manager id list
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
            cmbManagerID.ItemsSource = managerIDList;
        }

        private void CreateGroup_Click(object sender, RoutedEventArgs e)
        {
            string name = txtGroupName.Text;
            int groupID = GetLastID.GetLast("group", "GroupID") + 1;

            try
            {
                string connectionString = DBConnection.GetConnectionString();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Add group information to the group table
                    using (MySqlCommand groupCommand = new MySqlCommand("INSERT INTO `group` (`GroupID`, `GroupName`, `managerID`, `Balance`, `TotalSize`) VALUES (@groupID, @name, @managerID, @balance, @TotalSize)", connection))
                    {
                        groupCommand.Parameters.AddWithValue("@groupID", groupID);
                        groupCommand.Parameters.AddWithValue("@name", name);
                        groupCommand.Parameters.AddWithValue("@managerID", Convert.ToInt32(cmbManagerID.SelectedItem));
                        groupCommand.Parameters.AddWithValue("@balance", 0);
                        groupCommand.Parameters.AddWithValue("@TotalSize", 0);

                        groupCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void cmbManagerID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int managerID = Convert.ToInt32(cmbManagerID.SelectedItem);                            

        }
    }
}
