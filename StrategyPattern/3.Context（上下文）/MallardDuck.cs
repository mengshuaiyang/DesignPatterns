using StrategyPattern.Behaviors.Fly;
using StrategyPattern.Behaviors.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new Fly();
            quackBehavior = new Quack();
            Name = "绿头鸭";
        }
    }
}
