using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            name = "蛤蜊披萨";
            dough = "蛤蜊面团";
            sauce = "蛤蜊酱";

            toppings.Add("配料1 蛤蜊意大利奶酪");
        }

        public override void Bake()
        {
            Console.WriteLine("我要烘焙 1 个小时");
        }
    }
}
