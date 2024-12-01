using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 抽象类
    /// 定义了模板方法和算法框架，以及一些基本操作的默认实现。
    /// </summary>
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
        /// <summary>
        /// 模板方法提供了算法的框架，允许子类复用代码。
        /// </summary>
        protected virtual void PourInCup()
        {
            Console.WriteLine("倒入一个大杯子里");
        }
        protected abstract void AddCondiments();
    }
}
