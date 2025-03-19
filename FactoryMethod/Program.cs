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
            //ICreator creatorA = new CircularCreator();
            //IShape shape = creatorA.CreateShape();
            //shape.ShapeInfo();


            //ICreator productA = new RectangleCreator();
            //IShape shape2 = productA.CreateShape();
            //shape2.ShapeInfo();


            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape1 = shapeFactory.CreateShape<IShape>(typeof(Circular));
            shape1.ShapeInfo();

            IShape shape2 = shapeFactory.CreateShape<IShape>(typeof(Rectangle));
            shape2.ShapeInfo();

            IShape shape3 = shapeFactory.CreateShape<IShape>(typeof(Square));
            shape3.ShapeInfo();

            Console.ReadKey();
        }
    }
}
