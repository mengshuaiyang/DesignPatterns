using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns.Factory
{
    public class DuckCounterFactory : AbstractDuckFactory
    {
        public override Quackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override Quackable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override Quackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }
       
        public override Quackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
