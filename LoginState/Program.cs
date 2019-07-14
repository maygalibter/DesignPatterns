using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context(new newLogin());
            ctx.pressedLogin("1234"); // Login succeed
            ctx.pressedLogin("1111"); // Already Login 
            ctx.pressedRestart(); // Restart from login
            ctx.pressedLogin("12345"); // Login failed
            ctx.pressedLogin("123"); // Login Failed, last chance
            ctx.pressedLogin("4567"); // Lock from failed after 3 times
            ctx.pressedLogin("1234"); // Already Lock
            ctx.pressedRestart(); // Restart
            ctx.pressedLogin("1234"); // New Login succeed
            ctx.pressedRestart(); // Restart
            ctx.pressedLogin("1111"); // failed 1
            ctx.pressedLogin("11112"); // failed 2
            ctx.pressedRestart(); // Restart
            ctx.pressedLogin("11112"); // failed 3 not lock


        }
    }
}
