using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle(new Point(5, 5), 50.5);

            Console.WriteLine("**Circle**");
            Console.WriteLine("\nOriginal");
            Console.WriteLine("________");
            Console.WriteLine(c);

            DoStuffWithCircle(c.clone() as Circle);

            Console.WriteLine("\nSend clone");
            Console.WriteLine("__________");
            Console.WriteLine(c);


            DoStuffWithCircle(c);

            Console.WriteLine("\nSend original");
            Console.WriteLine("_____________");
            Console.WriteLine(c);
            Console.WriteLine("======================================");

            Rectangle r = new Rectangle(new Point(1, 1), new Point(1, 3), new Point(3, 1), new Point(3, 3));

            Console.WriteLine("\n**Rectangle**");
            Console.WriteLine("\nOriginal");
            Console.WriteLine("________");
            Console.WriteLine(r);

            DoStuffWithRectangle(r.clone() as Rectangle);

            Console.WriteLine("\nSend clone");
            Console.WriteLine("__________");
            Console.WriteLine(r);


            DoStuffWithRectangle(r);

            Console.WriteLine("\nSend original");
            Console.WriteLine("_____________");
            Console.WriteLine(r);
            Console.WriteLine("======================================");

            Console.WriteLine("\n**Shape**");
            Circle c1 = new Circle(new Point(1, 1), 3.14);
            Circle c2 = new Circle(new Point(2, 2), 6.28);
            Rectangle r1 = new Rectangle(new Point(1, 1), new Point(1, 4), new Point(3, 1), new Point(3, 4));
            ShapeHolder s = new ShapeHolder();
            s.list.Add(c1);
            s.list.Add(c2);
            s.list.Add(r1);

            // Print original shapeholder
            Console.WriteLine("\nOriginal Shape list");
            Console.WriteLine("___________________");
            s.PrintShapeList();

            // Create clone
            ShapeHolder sClone = s.clone();

            DoStuffWithCircle(c1);
            DoStuffWithRectangle(r1);

            // Print original after change
            Console.WriteLine("\nOriginal Shape list after change");
            Console.WriteLine("________________________________");
            s.PrintShapeList();

            // Print clone after change
            Console.WriteLine("\nClone Shape list after change");
            Console.WriteLine("________________________________");
            sClone.PrintShapeList();


        }

        public static void DoStuffWithCircle(Circle c)
        {
            c.Center.X = 15;
            c.Area = -5;
        }

        public static void DoStuffWithRectangle(Rectangle r)
        {
            r.point1.X = 1;
            r.point1.Y = 2;
            r.point3.X = 3;
            r.point3.Y = 2;
        }
    }
}
