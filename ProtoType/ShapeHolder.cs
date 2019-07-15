using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class ShapeHolder : IProtoType<ShapeHolder>
    {
        public List<Shape> list = new List<Shape>();

        public ShapeHolder clone()
        {
            ShapeHolder sh = new ShapeHolder();

            foreach (Shape s in list)
            {
                sh.list.Add(s.clone());
            }

            return sh;
        }

        public void PrintShapeList()
        {
            foreach (Shape s in list)
            {
                Console.WriteLine(s);
            }
        }

    }
}
