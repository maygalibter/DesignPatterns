using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public interface ICustomer
    {
        void BuyTicket(string name, string dest);
        void ShowMyTickets(string name);
    }
}
