using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    public class Locked : ILoginState
    {
        public ILoginState Login(string pass)
        {
            Console.WriteLine("System is locked !");
            return this;
        }

        public ILoginState Restart()
        {
            Console.WriteLine("Restart...");
            return new newLogin();

        }
    }
}
