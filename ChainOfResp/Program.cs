using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    class Program
    {
        static void Main(string[] args)
        {
            BillHandlerBase billHandler500 = new BillHandler500();
            BillHandlerBase billHandler200 = new BillHandler200();
            BillHandlerBase billHandler100 = new BillHandler100();
            BillHandlerBase billHandler25 = new BillHandler25();
            BillHandlerBase coinHandler5 = new CoinHandler5();
            BillHandlerBase coinHandler2 = new CoinHandler2();

            BillHandlerBase chainRoot = billHandler500;
            billHandler500.SetNext(billHandler200);
            billHandler200.SetNext(billHandler100);
            billHandler100.SetNext(billHandler25);
            billHandler25.SetNext(coinHandler5);
            coinHandler5.SetNext(coinHandler2);

            Console.WriteLine("*** Welcome to your bank ***");

            Console.WriteLine("Amount 502:");
            chainRoot.Handle(502);
            Console.WriteLine("================");
            Console.WriteLine("Amount 385:");
            chainRoot.Handle(385);
            Console.WriteLine("================");
            Console.WriteLine("Amount 400:");
            chainRoot.Handle(400);
            Console.WriteLine("================");
            Console.WriteLine("Amount 174:");
            chainRoot.Handle(174);
            Console.WriteLine("================");

        }
    }
}
