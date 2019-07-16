using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WebClientData
    {
        public string Name;
        public string Id;
        public string Ip;
        public bool Ssl;

        public WebClientData(string name, string id, string ip, bool ssl)
        {
            Name = name;
            Id = id;
            Ip = ip;
            Ssl = ssl;
        }
    }
}
