using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    class Provider
    {
        // ProviderID        ProviderName

        public int ProviderID { get; set; }
        public string ProviderName { get; set; }

        public Provider(int providerID, string providerName)
        {
            ProviderID = providerID;
            ProviderName = providerName;
        }


    }
}
