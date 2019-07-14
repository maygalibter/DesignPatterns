using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    public class newLogin : ILoginState 
    {
        public ILoginState Login(string pass)
        {
            if(string.Compare("1234", pass) == 0)
            {
                Console.WriteLine("Login succeed !");
                return new loginSucceed();
            }

            Console.WriteLine("Login Failed !");
            return new loginFailed();
        }

        public ILoginState Restart()
        {
            Console.WriteLine("Restart...");
            return this;
            
        }
    }
}
