using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    class AddNewPerson : person
    {
        string adress {get;set;}
        string phoneNumber { get; set; }
        string email { get; set; }

        public AddNewPerson(string firstName, string lastName, int roleID, int login, int personID, int unitID, int contactID, string adress, string phoneNumber, string email) : base(firstName, lastName, roleID, login, personID, unitID, contactID)
        {
            this.adress = adress;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public static void AddPerson(string firstName, string lastName, int roleID, int login, int personID, int unitID, int contactID, string address, string phoneNumber, string email)
        {
            try
            {
                string connectionString = DBConnection.GetConnectionString();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Add login information to the login table
                    using (MySqlCommand loginCommand = new MySqlCommand("INSERT INTO login (Login, Username, Password) VALUES (@loginID, @userName, @password)", connection))
                    {
                        loginCommand.Parameters.AddWithValue("@loginID", login);
                        loginCommand.Parameters.AddWithValue("@userName", firstName);
                        loginCommand.Parameters.AddWithValue("@password", lastName);
                        loginCommand.ExecuteNonQuery();
                    }

                    // Add person information to the person table
                    using (MySqlCommand personCommand = new MySqlCommand("INSERT INTO person (PersonID, FirstName, LastName, RoleID, UnitID, ContactID, Login) VALUES (@personID, @firstName, @lastName, @roleID, @unitID, @ContactID, @loginID)", connection))
                    {
                        personCommand.Parameters.AddWithValue("@personID", personID);
                        personCommand.Parameters.AddWithValue("@firstName", firstName);
                        personCommand.Parameters.AddWithValue("@lastName", lastName);
                        personCommand.Parameters.AddWithValue("@unitID", unitID);
                        personCommand.Parameters.AddWithValue("@roleID", roleID);
                        personCommand.Parameters.AddWithValue("@ContactID", contactID);
                        personCommand.Parameters.AddWithValue("@loginID", login);
                        personCommand.ExecuteNonQuery();
                    }

                    

                    // Add contact information to the contact table
                    using (MySqlCommand contactCommand = new MySqlCommand("INSERT INTO contact (ContactID, Address, Phone, Email) VALUES (@contactID, @address, @phoneNumber, @email)", connection))
                    {
                        contactCommand.Parameters.AddWithValue("@contactID", contactID);
                        contactCommand.Parameters.AddWithValue("@address", address);
                        contactCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        contactCommand.Parameters.AddWithValue("@email", email);
                        contactCommand.ExecuteNonQuery();
                    }

                    

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., log or display an error message)
                Console.WriteLine("Error adding person to the database: " + ex.Message);
            }
        }

    }
}
