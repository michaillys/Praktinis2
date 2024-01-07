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
    /// Interaction logic for AddUnitToGroup.xaml
    /// </summary>
    public partial class AddUnitToGroup : Window
    {
        public AddUnitToGroup()
        {
            InitializeComponent();

            //get unit id list
            List<int> unitIDList = new List<int>(GetIDList.GetUnitIDList());
            cmbUnitID.ItemsSource = unitIDList;

            //get group id list
            List<int> groupIDList = new List<int>(GetIDList.GetGroupIDList());
            cmbGroupID.ItemsSource = groupIDList;      

        }

        

        private void AsignGroup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // chenge unit group id
                string connectionString = DBConnection.GetConnectionString();
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "UPDATE unit SET GroupID = @GroupID WHERE UnitID = @UnitID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@GroupID", cmbGroupID.SelectedItem);
                command.Parameters.AddWithValue("@UnitID", cmbUnitID.SelectedItem);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Unit was assigned to group");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
