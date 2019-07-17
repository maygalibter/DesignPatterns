using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calc with 5
            Console.WriteLine("Base number : 5");
            IFormula formula = new StartNumber(5);

            IFormula mulFormula = new Mul(formula, 2);
            IFormula addFormula = new Add(mulFormula, 100);
            IFormula divFormula = new Div(addFormula, 12);
            IFormula subFormula = new Sub(divFormula, 3);
            IFormula mulFormula2 = new Mul(subFormula, 4);
            IFormula addFormula2 = new Add(mulFormula2, 7);

            Console.WriteLine("Formula : " + addFormula2.GetFormula());
            Console.WriteLine("Result : " + addFormula2.GetResult().ToString());
            Console.WriteLine("================================================\n");

            // Calc witv 30
            Console.WriteLine("Base number : 30");
            IFormula nformula = new StartNumber(30);

            IFormula nmulFormula = new Mul(nformula, 2);
            IFormula naddFormula = new Add(nmulFormula, 100);
            IFormula ndivFormula = new Div(naddFormula, 12);
            IFormula nsubFormula = new Sub(ndivFormula, 3);
            IFormula nmulFormula2 = new Mul(nsubFormula, 4);
            IFormula naddFormula2 = new Add(nmulFormula2, 7);

            Console.WriteLine("Formula : " + naddFormula2.GetFormula());
            Console.WriteLine("Result : " + naddFormula2.GetResult().ToString());
         

        }
    }
}
