using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // 现代风格的具体产品：现代沙发
    public class ModernSofa : Sofa
    {
        public void Display()
        {
            Console.WriteLine("现代沙发");
        }
    }
}
