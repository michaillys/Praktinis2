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
    /// Interaction logic for ManageGroups.xaml
    /// </summary>
    public partial class ManageGroups : Window
    {
        public ManageGroups()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CreateGroup_Click(object sender, RoutedEventArgs e)
        {
            CreateGroup createGroupWindow = new CreateGroup();
            createGroupWindow.ShowDialog();
        }

        private void AddUnitToGroup_Click(object sender, RoutedEventArgs e)
        {
            AddUnitToGroup addUnitToGroupWindow = new AddUnitToGroup();
            addUnitToGroupWindow.ShowDialog();            
        }

        private void AssignManager_Click(object sender, RoutedEventArgs e)
        {
            AssignManager assignManagerWindow = new AssignManager();
            assignManagerWindow.ShowDialog();            
        }
    }
}
