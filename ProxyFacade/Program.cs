using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory pFactory = new ProxyFactory();

            // Cannot login
            pFactory.Login("itay", "1111111");
            Console.WriteLine("=========================================");

            // Customer login

            ClientProxy cliProxy = pFactory.Login("ron", "1234");
            (cliProxy as CustomerProxy).BuyTicket("ron", "Thailand");
            (cliProxy as CustomerProxy).ShowMyTickets("ron");
            Console.WriteLine("=========================================");
            // Company login

            ClientProxy comProxy = pFactory.Login("aeroflot", "4321");
            (comProxy as CompanyProxy).CreateFlight("49H56", "Russian", "14:00");
            (comProxy as CompanyProxy).CancleFlight("17C67R");
            Console.WriteLine("=========================================");

            // Admin login

            ClientProxy admProxy = pFactory.Login("may", "1111");
            (admProxy as AdminProxy).CreateCompany("ELAL");
            (admProxy as AdminProxy).CreateCustomer("bar");

        }
    }
}
