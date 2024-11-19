using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Soy : ComponentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDesciption()
        {
            return beverage.GetDesciption()+ ",Soy(.3)";
        }

        public override double Cost()
        {
            return beverage.Cost() + .3;
        }
    }
}
