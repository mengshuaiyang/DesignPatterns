using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            desciption = "HouseBlend(.89)";
        }
        public override double Cost()
        {
            return .89;
        }
    }
}
