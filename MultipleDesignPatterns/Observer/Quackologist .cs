using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 具体的观察者类，比如嘎嘎叫学家
    /// </summary>
    public class Quackologist : Observer
    {
        public void Update(QuackObservable quackObservable)
        {
            // 当QuackObservable对象调用NotifyObservers时，这里会被调用
            Console.WriteLine($"嘎嘎叫学家开始观察 {quackObservable} 了...");
        }
    }

}
