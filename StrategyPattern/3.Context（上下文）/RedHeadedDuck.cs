using StrategyPattern.Behaviors.Fly;
using StrategyPattern.Behaviors.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RedHeadedDuck : Duck
    {
        public RedHeadedDuck()
        {
            flyBehavior = new Fly();
            quackBehavior = new SQuack();
            Name = "我是红头鸭";
        }
    }
}
