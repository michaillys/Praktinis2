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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace Praktinis2
{
    /// <summary>
    /// Interaction logic for ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        public ManagerPage(Manager manager)
        {
            InitializeComponent();

            DataContext = manager;

           

        }

        private void NewService_Click(object sender, RoutedEventArgs e)
        {
            NewServiceWindow newServiceWindow = new NewServiceWindow();
            newServiceWindow.Show();
        }

        private void GroupServices_Click(object sender, RoutedEventArgs e)
        {
            ServicesList.Visibility = Visibility.Visible;
            RequestsList.Visibility = Visibility.Hidden;
            // display last 10 services from database
            List<Service> services = new List<Service>();

            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int ListItemCount = 10;
                    string query = "SELECT * FROM service ORDER BY serviceID DESC LIMIT " + ListItemCount.ToString();
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Service service = new Service(reader.GetInt32(0), reader.GetString(1), reader.GetFloat(2), reader.GetInt32(3), reader.GetDateTime(4), reader.GetInt32(5));
                                services.Add(service);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            // Update the ServicesList.ItemsSource with the retrieved services
            ServicesList.ItemsSource = services;
        }

        private void ViewRequests_Click(object sender, RoutedEventArgs e)
        {
            RequestsList.Visibility = Visibility.Visible;
            ServicesList.Visibility = Visibility.Hidden;

            List<Request> requests = new List<Request>();



            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int ListItemCount = 10;
                    string query = "SELECT * FROM request ORDER BY requestID DESC LIMIT " + ListItemCount.ToString();
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Request request = new Request(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetString(3), reader.GetString(4));
                                requests.Add(request);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            RequestsList.ItemsSource = requests;
        }
    }
}
