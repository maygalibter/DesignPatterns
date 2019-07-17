using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class CompanyProxy : ClientProxy, ICompany
    {
        public void CancleFlight(string flightNum)
        {
            f.CancleFlight(flightNum);
        }

        public void CreateFlight(string flightNum, string dest, string time)
        {
            f.CreateFlight(flightNum, dest, time);
        }
    }
}
