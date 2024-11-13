using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            desciption = "Expresso(1.99)";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
