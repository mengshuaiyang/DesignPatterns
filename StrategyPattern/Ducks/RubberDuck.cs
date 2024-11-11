using StrategyPattern.Behaviors.Fly;
using StrategyPattern.Behaviors.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new NoFly();
            quackBehavior = new SQuack();
            Name = "我是诱惑鸭";
        }
    }
}

