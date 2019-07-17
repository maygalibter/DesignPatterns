using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class CustomerProxy : ClientProxy, ICustomer
    {
        public void BuyTicket(string name, string dest)
        {
            f.BuyTicket(name, dest);
        }

        public void ShowMyTickets(string name)
        {
            f.ShowMyTickets(name);
        }
    }
}
