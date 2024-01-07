using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleID { get; set; }
        public int Login { get; set; }

       
        public User(string firstName, string lastName, int roleID, int login)
        {
            FirstName = firstName;
            LastName = lastName;
            RoleID = roleID;
            Login = login;
        }
    }
}
