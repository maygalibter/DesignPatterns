using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock c1 = Clock.GetInstance();
            Clock c2 = Clock.GetInstance();
            Clock c3 = Clock.GetInstance();

            c1.GetTime();
            c2.GetTime();
            c3.GetTime();
        }
    }
}
