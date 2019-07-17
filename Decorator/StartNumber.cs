using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCalc
{
    public class StartNumber : IFormula
    {
        double Number;

        public StartNumber(double num)
        {
            this.Number = num;
        }
        public string GetFormula()
        {
            return Number.ToString();
        }

        public double GetResult()
        {
            return Number;
        }
    }
}
