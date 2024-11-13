using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Milk : ComponentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {

        }

        public override string GetDesciption()
        {
            return beverage.GetDesciption()+ ",Milk(.1)";
        }

        public override double Cost()
        {
            return beverage.Cost() + .1;
        }
    }
}
