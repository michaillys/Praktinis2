using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    public class Manager : User
    {
        public int ManagerID { get; set; }
        public Manager(string firstName, string lastName, int roleID, int login, int managerID) : base(firstName, lastName, roleID, login)
        {
            ManagerID = managerID;
        }

    }
}
