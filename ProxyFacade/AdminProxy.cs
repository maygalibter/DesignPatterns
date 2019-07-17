using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class AdminProxy : ClientProxy, IAdmin
    {
        public void CreateCompany(string name)
        {
            f.CreateCompany(name);
        }

        public void CreateCustomer(string name)
        {
            f.CreateCustomer(name);
        }
    }
}
