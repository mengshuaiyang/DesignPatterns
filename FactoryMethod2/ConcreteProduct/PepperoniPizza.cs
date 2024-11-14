using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "意大利辣香肠披萨";
            dough = "意大利辣面团";
            sauce = "意大利辣酱";
        }
    }
}
