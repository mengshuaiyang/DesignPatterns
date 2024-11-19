using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 鸭鸣器
    /// </summary>
    public class DuckCall : Quackable
    {
        public void Quack()
        {
            Console.WriteLine("鸭鸣器：模仿嘎嘎叫");
        }
    }
}
