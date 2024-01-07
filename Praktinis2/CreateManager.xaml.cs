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

namespace Praktinis2
{
    /// <summary>
    /// Interaction logic for CreateManager.xaml
    /// </summary>
    public partial class CreateManager : Window
    {
        public CreateManager()
        {
            InitializeComponent();
        }

        private void CreateManager_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int roleID = 1;
            int login = GetLastID.GetLast("login", "Login") + 1;
            

            AddNewManager.AddManager(firstName, lastName, roleID, login);

            this.Close();
        }
    }
}
