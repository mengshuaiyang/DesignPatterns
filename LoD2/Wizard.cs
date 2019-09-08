using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoD2
{
    //导向类：一个类公开的public属性或方法越多，修改时涉及的面也就越大，变更引起的风险扩散也就越大。在设计时需要反复衡量：是否还可以再减少public方法和属性，是否可以修改为private
    public class Wizard
    {
        private Random Rand = new Random();

        //第一步
        private int First()
        {
           Console.WriteLine("执行第一个方法...");
            return Rand.Next(100);
        }
        //第二步
        private int Second()
        {
            Console.WriteLine("执行第二个方法...");
            return Rand.Next(100);
        }
        //第三个方法
        private int Third()
        {
            Console.WriteLine("执行第三个方法...");
            return Rand.Next(100);
        }

        public void InstallWizard()
        {
            int first = First();
            //根据first返回的结果，看是否需要执行second
            if (first > 50)
            {
                int second = Second();
                if (second > 50)
                {
                    int third = Third();
                    if (third > 50)
                    {
                        First();
                    }
                }
            }
        }
    }
}
