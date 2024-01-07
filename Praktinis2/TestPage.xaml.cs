using MySql.Data.MySqlClient;
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


namespace Praktinis2
{
    /// <summary>
    /// Interaction logic for TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        public TestPage()
        {
            InitializeComponent();
        }
        private void TestConnection_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Database connection successful!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void GetTableNames_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = DBConnection.GetConnectionString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SHOW TABLES;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        tableListView.Items.Clear();

                        while (reader.Read())
                        {
                            string tableName = reader.GetString(0);
                            tableListView.Items.Add(new ListViewItem { Content = tableName });
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Failed to retrieve table names: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
