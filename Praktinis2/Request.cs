using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    public class Request
    {

        public int RequestID { get; set; }
        public int PersonID { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }


        public Request(int requestID, int personID, DateTime date, string status, string description)
        {
            RequestID = requestID;
            PersonID = personID;
            Date = date;
            Status = status;
            Description = description;
        }
        
        
    }
}
