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
    /// Interaction logic for AssignManager.xaml
    /// </summary>
    public partial class AssignManager : Window
    {
        public AssignManager()
        {
            InitializeComponent();
            
            
            List<int> managerIDList = new List<int>(GetIDList.GetManagerIDList());
            cmbManagerID.ItemsSource = managerIDList;            
                        
            List<int> groupIDList = new List<int>(GetIDList.GetGroupIDList());
            cmbGroupID.ItemsSource = groupIDList;
        }

        private void AssignManagerToGroup_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                string connectionString = DBConnection.GetConnectionString();
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "UPDATE `group` SET ManagerID = @ManagerID WHERE GroupID = @GroupID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ManagerID", cmbManagerID.SelectedItem);
                command.Parameters.AddWithValue("@GroupID", cmbGroupID.SelectedItem);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Manager was assigned to group");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
