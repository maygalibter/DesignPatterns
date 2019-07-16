using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ClientData
    {
        public string Name;
        public string Id;
        
        public ClientData(string name, string id)
        {
            Name = name;
            Id = id;
        }
        
    }
}
