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
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {

            
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int roleID = 2;
            int login = GetLastID.GetLast("login", "Login") + 1;
            int personID = GetLastID.GetLast("person", "PersonID") + 1;
            int unitID = GetLastID.GetLast("unit", "UnitID") + 1;
            int contactID = GetLastID.GetLast("contact", "ContactID") + 1;
            string address = firstName + lastName + "Address";
            string phoneNumber = "+37060000000";
            string email = firstName + "." + lastName + "@example.com";

           

            AddNewPerson.AddPerson(firstName,lastName,roleID, login, personID, unitID, contactID, address, phoneNumber, email);

            CreateUnit.AddUnit(unitID, 50, firstName + "Unit" + unitID, personID);

            
           

            this.Close();
        }
        
    }
}
