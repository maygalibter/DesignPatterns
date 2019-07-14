using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    public class Context
    {
        ILoginState state;

        public Context(ILoginState state)
        {
            this.state = state;
        }

        public void pressedLogin(string pass)
        {
            this.state = state.Login(pass);
        }

        public void pressedRestart()
        {
            this.state = state.Restart();
        }
    }
}