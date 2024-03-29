﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmOn : ILightState
    {
        public ILightState TurnOn()
        {
            Console.WriteLine("You broke it!");
            return new IAmBroken();
        }
        public ILightState TurnOff()
        {
            Console.WriteLine("Turning off the light!");
            return new IAmOff();
        }

        public ILightState Fix()
        {
            Console.WriteLine("Already Fixed!");
            return this;
        }
    }
}
