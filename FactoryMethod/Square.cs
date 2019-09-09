using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Square : IShape
    {
        public void ShapeInfo()
        {
            Console.WriteLine("画一个正方形");
        }
    }
}
