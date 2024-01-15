using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public float ServiceRate { get; set; }
        public int ProviderID { get; set; }
        public DateTime Date { get; set; }
        public int GroupBillID { get; set; }

        public Service(string serviceName, float serviceRate, int providerID, DateTime date, int groupBillID)
        {
            ServiceName = serviceName;
            ServiceRate = serviceRate;
            ProviderID = providerID;
            Date = date;
            GroupBillID = groupBillID;
        }

        public Service(int serviceID, string serviceName, float serviceRate, int providerID, DateTime date, int groupBillID)
        {
            ServiceID = serviceID;
            ServiceName = serviceName;
            ServiceRate = serviceRate;
            ProviderID = providerID;
            Date = date;
            GroupBillID = groupBillID;
        }
    }
}
