using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Whip : ComponentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDesciption()
        {
            return beverage.GetDesciption()+ ",Whip(.4)";
        }

        public override double Cost()
        {
            return beverage.Cost() + .4;
        }
    }
}
