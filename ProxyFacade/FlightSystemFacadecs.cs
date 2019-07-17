using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class FlightSystemFacadecs : ICustomer, ICompany, IAdmin
    {
        private FlightDAO dao = new FlightDAO();

        public void BuyTicket(string name, string dest)
        {
            dao.InsertTicket(name, dest);
        }
        public void ShowMyTickets(string name)
        {
            dao.GetTickets(name);
        }
        public void CreateFlight(string flightNum, string dest, string time)
        {
            dao.InsertFlight(flightNum, dest, time);
        }
        public void CancleFlight(string flightNum)
        {
            dao.RemoveFlight(flightNum);
        }
        public void CreateCustomer(string name)
        {
            dao.InsertCustomer(name);
        }
        public void CreateCompany(string name)
        {
            dao.InsertCompany(name);
        }

    }
}
