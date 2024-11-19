using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 绿头鸭
    /// </summary>
    public class MallardDuck : Quackable
    {
        public void Quack()
        {
            Console.WriteLine("绿头鸭：嘎嘎叫");
        }
    }
}
