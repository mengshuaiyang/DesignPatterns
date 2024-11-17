using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // 古典风格的具体产品：古典桌子
    public class ClassicTable : Table
    {
        public void Display()
        {
            Console.WriteLine("古典桌子");
        }
    }
}
