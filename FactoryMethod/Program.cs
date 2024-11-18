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
            ICreator creatorA = new CircularCreator();
            IShape shape = creatorA.CreateShape();
            shape.ShapeInfo();


            ICreator productA = new RectangleCreator();
            IShape shape2 = productA.CreateShape();
            shape2.ShapeInfo();
            Console.ReadKey();
        }
    }
}
