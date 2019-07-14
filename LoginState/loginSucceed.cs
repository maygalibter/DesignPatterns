using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    public class loginSucceed : ILoginState
    {
        public ILoginState Login(string pass)
        {
            Console.WriteLine("You are already logged in...");
            return this;
        }

        public ILoginState Restart()
        {
            Console.WriteLine("Restart...");
            return new newLogin();

        }
    }
}
