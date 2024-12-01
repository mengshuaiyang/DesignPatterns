using StrategyPattern.Behaviors;
using StrategyPattern.Behaviors.Fly;
using StrategyPattern.Behaviors.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck() 
        {
            flyBehavior=new NoFly();
            quackBehavior=new NoQuack();
            Name = "模型鸭";
        }
    }
}
