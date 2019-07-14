using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Truck : Vehicle
    {
        protected string driverTatto;

        public Truck(string model, float cylinder, string color, int numberOfWheels, string driverTatto) : base(model, cylinder, color, numberOfWheels)
        {
            this.driverTatto = driverTatto;
        }

        public override string ToString()
        {
            return "Truck " + base.ToString() + $" {driverTatto}";
        }
    }
}
