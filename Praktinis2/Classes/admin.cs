using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    public class Admin : User
    {
        public int AdminID { get; set; }
        public Admin(string firstName, string lastName, int roleID, int login, int adminID) : base(firstName, lastName, roleID, login)
        {
            AdminID = adminID;
        }
    }
}
