using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Latte();
            coffee.BrewCoffee();

            Console.WriteLine("***********");

            Coffee coffee1 = new Espresso();
            coffee1.BrewCoffee();

            Console.ReadKey();
        }
    }
}
