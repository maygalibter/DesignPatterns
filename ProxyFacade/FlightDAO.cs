using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class FlightDAO
    {
        public void InsertTicket(string name, string dest)
        {
            Console.WriteLine($"Buying new ticket... Customer : {name} Destination : {dest}");
        }
        public void GetTickets(string name)
        {
            Console.WriteLine($"Showing {name} tickets ...");
        }
        public void InsertFlight(string flightNum, string dest, string time)
        {
            Console.WriteLine($"Creating new flight ... Flight number : {flightNum} Destination : {dest} Boarding at : {time}");
        }
        public void RemoveFlight(string flightNum)
        {
            Console.WriteLine($"Removing flight {flightNum} ...");
        }
        public void InsertCustomer(string name)
        {
            Console.WriteLine($"Creating new customer ... Name : {name}");
        }
        public void InsertCompany(string name)
        {
            Console.WriteLine($"Creating new company... Company : {name}");
        }
       
    }
}
