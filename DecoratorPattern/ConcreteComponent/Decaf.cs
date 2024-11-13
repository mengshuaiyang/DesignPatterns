using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            desciption = "Decaf(2.99)";
        }
        public override double Cost()
        {
            return 2.99;
        }
    }
}
