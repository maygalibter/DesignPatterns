using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HamburgerBuilder> menu = new List<HamburgerBuilder>();
            menu.Add(new VeggHamburgerBuilder());
            menu.Add(new VeggHambBuilderLettuce());
            menu.Add(new SusuBuilder());
            menu.Add(new SusuBuilderLettuce());

            Hamburger hamb = PrepareHamburger(menu[0]);

            // Burger Factory
            BurgerFactory bFactory = new BurgerFactory();

            Hamburger v = bFactory.CreateBurger("veggie");
            Hamburger vl = bFactory.CreateBurger("veggie lettuce");
            Hamburger s = bFactory.CreateBurger("susu");
            Hamburger sl = bFactory.CreateBurger("susu lettuce");
        }

        static Hamburger PrepareHamburger(HamburgerBuilder builder)
        {
            builder.BuildHamburger();
            return builder.GetHamburger();
        }
    }
}
