using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    public class loginFailed : ILoginState
    {
        private int count = 1;
        public ILoginState Login(string pass)
        {
            count++;
            if ((count < 3)&(string.Compare("1234", pass) == 0))
            {
                Console.WriteLine("Login succeed !");
                return new loginSucceed();
            }
            else if (count == 3)
            {
                Console.WriteLine("Third fail, Locked !");
                return new Locked();
            }

            Console.WriteLine("Login Failed, Last chance !");
            return this;
        }

        public ILoginState Restart()
        {
            Console.WriteLine("Restart...");
            return new newLogin();

        }
    }
}
