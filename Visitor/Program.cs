using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquor vodka = new Liquor(95);

            Console.WriteLine(vodka);

            IVisitor endOfYearVisitor = new EndOfYearTax();

            Console.WriteLine($"Price after tax = {vodka.Accept(endOfYearVisitor)}");

            // Create new perfume

            Perfume channel = new Perfume(400);

            Console.WriteLine(channel);

            // Create new visitor

            IVisitor oneShekelVisitor = new OneShekelSale();

            Console.WriteLine($"Price after sale = {channel.Accept(oneShekelVisitor)}");

            // Create new shop rent

            ShopRent castro = new ShopRent(10000);
            Console.WriteLine(castro);
            Console.WriteLine($"Price after tax = {castro.Accept(endOfYearVisitor)}");
            Console.WriteLine($"Price after sale = {castro.Accept(oneShekelVisitor)}");


        }
    }
}