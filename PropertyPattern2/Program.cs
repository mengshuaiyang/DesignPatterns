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
            var clonedGraphic = originalGraphic.Clone(); 
                                                         
            var graphicClone = clonedGraphic as Graphic;
            graphicClone.Property = "Modified Circle";

            Console.WriteLine(originalGraphic.Property);
            Console.WriteLine(graphicClone.Property);

            Console.ReadKey();
        }
    }
}
