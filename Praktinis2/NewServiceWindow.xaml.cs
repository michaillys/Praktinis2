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
    /// Interaction logic for NewServiceWindow.xaml
    /// </summary>
    public partial class NewServiceWindow : Window
    {
        public NewServiceWindow()
        {
            InitializeComponent();

            

            
        }

        private void CreateService_Click(object sender, RoutedEventArgs e)
        {
            
            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO service (serviceID, serviceName, serviceRate, providerID, date, groupBillID) VALUES (@serviceID, @serviceName, @serviceRate, @providerID, @date, @groupBillID)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@serviceID", GetLastID.GetLast("service", "serviceID") + 1);
                    cmd.Parameters.AddWithValue("@serviceName", txtServiceName.Text);
                    cmd.Parameters.AddWithValue("@serviceRate", txtServiceRate.Text);
                    cmd.Parameters.AddWithValue("@providerID", txtProvidersID.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);                    
                    cmd.Parameters.AddWithValue("@groupBillID", txtGroupBillID.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Service added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
