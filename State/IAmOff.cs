using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmOff : ILightState
    {
        public ILightState TurnOn()
        {
            Console.WriteLine("Turning on the light!");
            return new IAmOn();
        }
        public ILightState TurnOff()
        {
            Console.WriteLine("Light is already turn off...");
            return this;
        }
        public ILightState Fix()
        {
            Console.WriteLine("Already Fixed!");
            return this;
        }
    }
}
