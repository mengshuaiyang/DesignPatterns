using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors.Fly
{
    internal class NoFly : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("我不会飞");
        }
    }
}
