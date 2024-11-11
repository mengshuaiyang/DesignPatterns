using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors.Fly
{
    internal class RocketFly : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("像火箭一样飞行");
        }
    }
}
