using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns.Factory
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override Quackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override Quackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override Quackable CreateDuckCall()
        {
            return new DuckCall();
        }
       
        public override Quackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
