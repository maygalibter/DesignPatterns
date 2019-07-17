using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
        public class BurgerFactory
        {
            public Hamburger CreateBurger(string burgerType)
            {
                if (burgerType == "veggie" )
                {
                    Console.WriteLine("Creating veggie burger...");
                    VeggHamburgerBuilder b = new VeggHamburgerBuilder();
                    b.BuildHamburger();

                    return b.GetHamburger();

                }
                else if (burgerType == "veggie lettuce")
                {
                    Console.WriteLine("Creating veggie lettuce burger...");
                    VeggHambBuilderLettuce b = new VeggHambBuilderLettuce();
                    b.BuildHamburger();

                    return b.GetHamburger();

                }
                else if (burgerType == "susu")
                {
                    Console.WriteLine("Creating susu burger...");
                    SusuBuilder b = new SusuBuilder();
                    b.BuildHamburger();

                    return b.GetHamburger();

                }
                else if (burgerType == "susu lettuce")
                {
                    Console.WriteLine("Creating susu lettuce burger...");
                    SusuBuilderLettuce b = new SusuBuilderLettuce();
                    b.BuildHamburger();

                    return b.GetHamburger();
                }

            throw new ArgumentException($"cannot create {burgerType} burger!");

             }
        }
    
}
