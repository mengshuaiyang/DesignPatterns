using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 具体类
    /// 实现或重写抽象类中的操作，填充算法框架的某些步骤。
    /// </summary>
    public class Espresso : Coffee
    {
        protected override void GroundCoffee()
        {
            Console.WriteLine("Grinding Italian Roast Coffee beans fine for Espresso");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brewing in an Espresso Machine");
        }

        /// <summary>
        /// 子类可以重写某些步骤，而不需要改变算法的整体结构
        /// </summary>
        protected override void PourInCup()
        {
            Console.WriteLine("倒入小杯子中");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk froth");
        }
    }
}
