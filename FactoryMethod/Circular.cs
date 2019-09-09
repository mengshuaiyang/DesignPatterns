using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Circular : IShape
    {
        public void ShapeInfo()
        {
            Console.WriteLine("画一个圆形");
        }
    }
}
