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
    /// Interaction logic for adminPage.xaml
    /// </summary>
    public partial class adminPage : Page
    {
        public adminPage(Admin admin)
        {
            InitializeComponent();
            DataContext = admin;
        }

        private void CreateManager_Click(object sender, RoutedEventArgs e)
        {
            CreateManager createManagerWindow = new CreateManager();
            createManagerWindow.ShowDialog();
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {           
            CreateUser createUserWindow = new CreateUser();
            createUserWindow.ShowDialog();
        }

        private void ManageGroups_Click(object sender, RoutedEventArgs e)
        {
            ManageGroups manageGroupsWindow = new ManageGroups();
            manageGroupsWindow.ShowDialog();
        }
    }
}
