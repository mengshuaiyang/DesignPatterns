using StrategyPattern.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        //动态设定行为
        public void SetFlyBehavior(FlyBehavior _flyBehavior)
        {
            flyBehavior = _flyBehavior;
        }

        //动态设定行为
        public void SetQuackBehavior(QuackBehavior _quackBehavior)
        {
            quackBehavior = _quackBehavior;
        }

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public string Name;

        public void dispaly() 
        {
            Console.WriteLine($"我是{Name}");
        }

        public void swim()
        {
            Console.WriteLine($"我会游泳");
        }
    }
}
