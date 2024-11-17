using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    // 抽象类
    public abstract class Coffee
    {
        // 模板方法
        public void BrewCoffee()
        {
            GroundCoffee();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void GroundCoffee();
        protected abstract void Brew();
        protected abstract void PourInCup();
        protected abstract void AddCondiments();
    }
}
