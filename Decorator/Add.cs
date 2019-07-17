﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCalc
{
    public class Add : CalcDecoratorBase
    {
        public Add(IFormula formula, double num) : base(formula, num)
        {
        }

        public override string GetFormula()
        {
            return $"{(Formula.GetFormula())} + {(Number)}";
        }

        public override double GetResult()
        {
            return Formula.GetResult() + Number;
        }
    }
}
