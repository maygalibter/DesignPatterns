
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context(new IAmOn());
            // Turning off
            ctx.pressedOff();
            // Turning on
            ctx.pressedOn();
            // Broken
            ctx.pressedOn();
            // Still broken
            ctx.pressedOn();
            // Still broken
            ctx.pressedOff();
            // Fix
            ctx.pressedFix();
            // Already off
            ctx.pressedOff();

        }
    }
}