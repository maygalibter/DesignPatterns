using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Segway : Vehicle
    {
        protected string driverCity;

        public Segway(string model, float cylinder, string color, int numberOfWheels, string driverCity) : base(model, cylinder, color, numberOfWheels)
        {
            this.driverCity = driverCity;
        }

        public override string ToString()
        {
            return "Segway " + base.ToString() + $" {driverCity}";
        }
    }
}
