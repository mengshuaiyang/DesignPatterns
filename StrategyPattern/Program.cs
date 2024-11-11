using StrategyPattern.Behaviors.Fly;
using StrategyPattern.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck=new MallardDuck();
            duck.dispaly();
            duck.performFly();
            duck.performQuack();
            duck.swim();

            //动态设定行为
            duck.SetFlyBehavior(new NoFly());
            duck.performFly();

            Console.WriteLine("*****");

            Duck duck2 = new ModelDuck();
            duck2.dispaly();
            duck2.performFly();
            duck2.performQuack();
            duck2.swim();

            Console.WriteLine("*****");

            Duck duck3 = new RedHeadedDuck();
            duck3.dispaly();
            duck3.performFly();
            duck3.performQuack();
            duck3.swim();

            Console.WriteLine("*****");

            Duck duck4 = new RubberDuck();
            duck4.dispaly();
            duck4.performFly();
            duck4.performQuack();
            duck4.swim();

            Console.ReadKey();
        }
    }
}
