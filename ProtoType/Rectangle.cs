using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class Rectangle : Shape
    {
        public Point point1 { get; set; }
        public Point point2 { get; set; }
        public Point point3 { get; set; }
        public Point point4 { get; set; }

        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            this.point1 = p1;
            this.point2 = p2;
            this.point3 = p3;
            this.point4 = p4;
        }

        public override string ToString()
        {
            return $"Rectangle points : First {point1},second {point2},third {point3},forth {point4}";
        }

        public override Shape clone()
        {
            return new Rectangle(point1.clone(), point2.clone(), point3.clone(), point4.clone());
        }

    }
}
