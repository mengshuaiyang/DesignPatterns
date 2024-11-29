using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var originalGraphic = new Graphic("Circle");
            var clonedGraphic = originalGraphic.Clone(); // 这里clonedGraphic是IPrototype类型
                                                         // 向下转型以访问Property属性
            var graphicClone = clonedGraphic as Graphic;
            graphicClone.Property = "Modified Circle";

            Console.WriteLine(originalGraphic.Property);
            Console.WriteLine(graphicClone.Property);

            Console.ReadKey();
        }
    }
}
