using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 红头鸭
    /// </summary>
    public class RedheadDuck : Quackable
    {
        public void Quack()
        {
            Console.WriteLine("红头鸭：嘎嘎叫");
        }
    }
}
