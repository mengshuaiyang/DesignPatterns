using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularFactory circularFactory = new CircularFactory();
            IShape shape = circularFactory.CreateShape();
            shape.ShapeInfo();


            ICreator creator = new RectangleFactory();
            IShape shape2 = creator.CreateShape();
            shape2.ShapeInfo();
            Console.ReadKey();
        }
    }
}
