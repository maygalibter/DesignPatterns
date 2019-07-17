using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class ProxyFactory
    {
        public ClientProxy Login(string username, string pass)
        {
            if ((username == "ron") & (pass == "1234"))
            {
                return new CustomerProxy();

            }
            else if ((username == "aeroflot") & (pass == "4321"))
            {
                return new CompanyProxy();

            }
            else if ((username == "may") & (pass == "1111"))
            {
                return new AdminProxy();

            }
            else
            {
                Console.WriteLine("Wrong username or password !");
                return null;

            }
            
        }
    }
}
