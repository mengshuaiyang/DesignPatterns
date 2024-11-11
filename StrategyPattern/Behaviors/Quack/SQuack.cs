using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors.Quack
{
    internal class SQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("吱吱叫");
        }
    }
}
