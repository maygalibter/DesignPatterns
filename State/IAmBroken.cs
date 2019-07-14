using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmBroken : ILightState
    {
        public ILightState TurnOn()
        {
            Console.WriteLine("Already broken");
            return this;
        }
        public ILightState TurnOff()
        {
            Console.WriteLine("Already broken");
            return this;
        }

        public ILightState Fix()
        {
            Console.WriteLine("Fix...");
            return new IAmOff();
        }
    }
}
