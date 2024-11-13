using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string desciption= "Unknow Beverage";

        public virtual string GetDesciption()
        {
            return desciption;
        }

        public abstract double Cost();
    }
}
