using StrategyPattern.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    /// <summary>
    /// 上下文
    /// 持有一个策略类的引用，可以动态调用策略对象的算法。
    /// </summary>
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
