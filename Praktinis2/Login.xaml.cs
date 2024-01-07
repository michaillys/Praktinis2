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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //check are all fields filled
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username cannot be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Password cannot be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            //check is user in database
            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Login FROM login WHERE username = @username AND password = @password;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string loginID = reader.GetString(0);                            
                            reader.Close();

                            //log login
                            LoginLog loginLog = new LoginLog();
                            int loginNr = Convert.ToInt32(loginID);
                            loginLog.LogLogin(loginNr);


                            
                            
                            
                            //check is user admin
                            query = "SELECT * FROM admin WHERE Login = @loginID;";
                            cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@loginID", loginID);

                            using (MySqlDataReader reader2 = cmd.ExecuteReader())
                            {
                                if (reader2.HasRows)
                                {
                                    reader2.Read();

                                    // Retrieve values from columns
                                    int adminID = reader2.GetInt32(reader2.GetOrdinal("AdminID"));
                                    string firstName = reader2.GetString(reader2.GetOrdinal("FirstName"));
                                    string lastName = reader2.GetString(reader2.GetOrdinal("LastName"));
                                    int roleID = reader2.GetInt32(reader2.GetOrdinal("RoleID"));
                                    int login = reader2.GetInt32(reader2.GetOrdinal("Login"));
                                    Admin admin = new Admin(firstName, lastName, roleID, login, adminID);
                                    reader2.Close();                                                                

                                //open adminPage.xaml page
                                adminPage adminPage = new adminPage(admin);
                                    this.NavigationService.Navigate(adminPage);
                                }
                                else
                                {
                                    reader2.Close();
                                    //check is user manager
                                    query = "SELECT * FROM manager WHERE Login = @loginID;";
                                    cmd = new MySqlCommand(query, connection);
                                    cmd.Parameters.AddWithValue("@loginID", loginID);

                                    using (MySqlDataReader reader3 = cmd.ExecuteReader())
                                    {
                                        if (reader3.HasRows)
                                        {
                                            reader3.Read();
                                            // Retrieve values from columns
                                            int managerID = reader3.GetInt32(reader3.GetOrdinal("ManagerID"));
                                            string firstName = reader3.GetString(reader3.GetOrdinal("FirstName"));
                                            string lastName = reader3.GetString(reader3.GetOrdinal("LastName"));
                                            int roleID = reader3.GetInt32(reader3.GetOrdinal("RoleID"));
                                            int login = reader3.GetInt32(reader3.GetOrdinal("Login"));
                                            Manager manager = new Manager(firstName, lastName, roleID, login, managerID);

                                            reader3.Close();
                                            //open managerPage.xaml page
                                            ManagerPage managerPage = new ManagerPage(manager);
                                            this.NavigationService.Navigate(managerPage);
                                        }
                                        else
                                        {
                                            reader3.Close();
                                            //check is user manager
                                            query = "SELECT * FROM person WHERE Login = @loginID;";
                                            cmd = new MySqlCommand(query, connection);
                                            cmd.Parameters.AddWithValue("@loginID", loginID);

                                            using (MySqlDataReader reader4 = cmd.ExecuteReader())
                                            {
                                                if (reader4.HasRows)
                                                {
                                                    reader4.Read();
                                                    // Retrieve values from columns
                                                    int personID = reader4.GetInt32(reader4.GetOrdinal("PersonID"));
                                                    string firstName = reader4.GetString(reader4.GetOrdinal("FirstName"));
                                                    string lastName = reader4.GetString(reader4.GetOrdinal("LastName"));
                                                    int roleID = reader4.GetInt32(reader4.GetOrdinal("RoleID"));
                                                    int login = reader4.GetInt32(reader4.GetOrdinal("Login"));
                                                    int unitID = reader4.GetInt32(reader4.GetOrdinal("UnitID"));
                                                    int contactID = reader4.GetInt32(reader4.GetOrdinal("ContactID"));

                                                    person person = new person(firstName, lastName, roleID, login, personID, unitID, contactID);

                                                    reader4.Close();
                                                    //open UserPage.xaml page
                                                    UserPage userPage = new UserPage(person);
                                                    this.NavigationService.Navigate(userPage);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Login failed!");
                                                }
                                            }
                                        }
                                    }
                                }
                                
                            }
                        }

                        else
                        {
                            MessageBox.Show("Login failed!");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
