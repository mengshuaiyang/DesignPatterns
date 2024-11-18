using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    public class VegglePizza : Pizza
    {
        public VegglePizza()
        {
            name = "蔬菜披萨";
            dough = "蔬菜面团";
            sauce = "蔬菜辣酱";

            toppings.Add("配料1 蔬菜意大利奶酪");
            toppings.Add("配料2 蔬菜意大利奶酪");
            toppings.Add("配料3 蔬菜意大利奶酪");
        }
    }
}
