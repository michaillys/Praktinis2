using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    public class person : User
    {
        public int personID { get; set; }
        public int UnitID { get; set; }
        public int ContactID { get; set; }

        public person(string firstName, string lastName, int roleID, int login, int personID, int unitID, int contactID) : base(firstName, lastName, roleID, login)
        {
            this.personID = personID;
            UnitID = unitID;
            ContactID = contactID;
        }
    }
}
