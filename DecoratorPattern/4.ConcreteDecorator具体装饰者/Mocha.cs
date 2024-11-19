using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mocha : ComponentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDesciption()
        {
            return beverage.GetDesciption()+ ",Mocha(.2)";
        }

        public override double Cost()
        {
            return beverage.Cost() + .2;
        }
    }
}
