using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCalc
{
    public abstract class CalcDecoratorBase : IFormula
    {
        protected IFormula Formula;

        protected double Number;
        public abstract string GetFormula();

        public abstract double GetResult();

        public CalcDecoratorBase(IFormula formula, double num)
        {
            this.Formula = formula;
            this.Number = num;
        }
    }
}
