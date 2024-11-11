using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors.Fly
{
    internal class Fly : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("这是一个普通的飞行动作");
        }
    }
}
