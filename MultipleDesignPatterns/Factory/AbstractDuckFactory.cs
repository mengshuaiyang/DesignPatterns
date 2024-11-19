using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns.Factory
{
    public abstract class AbstractDuckFactory
    {
        public abstract Quackable CreateMallardDuck();
        public abstract Quackable CreateRedheadDuck();
        public abstract Quackable CreateDuckCall();
        public abstract Quackable CreateRubberDuck();
    }
}
