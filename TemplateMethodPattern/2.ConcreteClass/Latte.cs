using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    // 具体类
    public class Latte : Coffee
    {
        protected override void GroundCoffee()
        {
            Console.WriteLine("Grinding French Roast Coffee beans coarse for Latte");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brewing in a French Press");
        }

        protected override void PourInCup()
        {
            Console.WriteLine("Pouring into a large cup");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding milk and a little bit of cinnamon");
        }
    }
}
