using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Expresso();
            Console.WriteLine($"{beverage.GetDesciption()} $ {beverage.Cost()}");

            Beverage beverage2 = new Expresso();
            beverage2 = new Milk(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Soy(beverage2);
            Console.WriteLine($"{beverage2.GetDesciption()} $ {beverage2.Cost()}");

            Beverage beverageMilk = new Milk(beverage2);
            Beverage beverageMocha = new Mocha(beverageMilk);
            Beverage beverageSoy = new Soy(beverageMocha);
            Console.WriteLine($"{beverageSoy.GetDesciption()} $ {beverageSoy.Cost()}");

            Console.ReadKey();
        }
    }
}
