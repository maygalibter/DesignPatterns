using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Check Perfect store
            ClientData cd = new ClientData("May", "316015833");
            PerfectStore ps = new PerfectStore();
            ps.store(cd);

            // Check Web data store
            Console.WriteLine("\n");
            WebClientData wcd = new WebClientData("Galibter", "316015833", "1.2.3.4", true);
            WebDataStore wds = new WebDataStore();
            wds.store(wcd);

        }
    }
}
