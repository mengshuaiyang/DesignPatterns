using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors.Quack
{
    internal class NoQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("啥都不会叫");
        }
    }
}
