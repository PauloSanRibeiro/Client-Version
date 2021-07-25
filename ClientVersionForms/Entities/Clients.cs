using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientVersionForms.Entities
{
    class Clients
    {
        public string NameClient { get; set; }
        public string UrlClient { get; set; }

        public Clients()
        {
        }

        public Clients(string nameClient, string urlClient)
        {
            NameClient = nameClient;
            UrlClient = urlClient;
        }
    }
}
