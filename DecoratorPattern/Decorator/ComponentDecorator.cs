using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class ComponentDecorator : Beverage
    {
        protected Beverage beverage;

        public ComponentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDesciption()
        {
            return beverage.GetDesciption();
        }

        public override double Cost()
        {
            return beverage.Cost();
        }
    }
}
