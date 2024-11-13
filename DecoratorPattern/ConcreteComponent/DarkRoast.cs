using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            desciption = "DarkRoast(10)";
        }
        public override double Cost()
        {
            return 10;
        }
    }
}
