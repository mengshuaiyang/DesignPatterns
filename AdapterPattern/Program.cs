using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client
            Shape shape = new LineShape();
            shape.BoundIngBox();
            shape.CreateManipuator();

            Shape shape1 = new PolygonShape();
            shape1.BoundIngBox();
            shape1.CreateManipuator();

            //为了通过统一接口使用TextView，创建适配器(TextShape)
            Shape shape2 = new TextShape();
            shape2.BoundIngBox();
            shape2.CreateManipuator();

            Shape shape3 = new TextAdapter();
            shape2.BoundIngBox();
            shape2.CreateManipuator();

            Console.ReadKey();
        }
    }
}
