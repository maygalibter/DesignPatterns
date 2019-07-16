using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WebDataStore : IDBWebData
    {
        public void store(WebClientData wc)
        {
            ClientData cd = new ClientData(wc.Name, wc.Id);
            PerfectStore ps = new PerfectStore();
            ps.store(cd);

            Console.WriteLine($"IP : {(wc.Ip)} \nSSL : {(wc.Ssl)}");
        }
    }
}
