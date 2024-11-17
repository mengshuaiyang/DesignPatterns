using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    // 具体类
    public class Espresso : Coffee
    {
        protected override void GroundCoffee()
        {
            Console.WriteLine("Grinding Italian Roast Coffee beans fine for Espresso");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brewing in an Espresso Machine");
        }

        protected override void PourInCup()
        {
            Console.WriteLine("Pouring into a small cup");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk froth");
        }
    }
}
