using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PerfectStore : IDBData
    {
        public void store(ClientData c)
        {
            Console.WriteLine("Perfect store storing");
            Console.WriteLine("======================");
            Console.WriteLine($"Details - \nName : {(c.Name)} \nID : {(c.Id)}");
        }
    }
}
