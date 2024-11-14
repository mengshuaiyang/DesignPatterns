using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    public class ChessePizza : Pizza
    {
        public ChessePizza()
        {
            name = "芝士披萨";
            dough = "芝士面团";
            sauce = "芝士姜";

            toppings.Add("配料1 芝士意大利奶酪");
            toppings.Add("配料2 芝士意大利奶酪");
            toppings.Add("配料3 芝士意大利奶酪");
        }

        public override void Cut()
        {
            Console.WriteLine("我是芝士切法");
        }
    }
}
