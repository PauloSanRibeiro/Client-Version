using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientVersion.Entites
{
    class Client
    {

        public string NameCliente { get; set; }
        public string UrlClient { get; set; }

        public Client()
        {
        }

        public Client(string nameCliente, string urlClient)
        {
            NameCliente = nameCliente;
            UrlClient = urlClient;
        }
    }
}
