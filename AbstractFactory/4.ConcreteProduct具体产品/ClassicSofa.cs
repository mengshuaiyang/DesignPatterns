using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // 古典风格的具体产品：古典沙发
    public class ClassicSofa : Sofa
    {
        public void Display()
        {
            Console.WriteLine("古典沙发");
        }
    }
}
