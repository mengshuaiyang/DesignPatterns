using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 静态初始化器来实现线程安全的单例模式
    /// </summary>
    public class SingletonThird
    {
        private static SingletonThird instance =new SingletonThird();

        private SingletonThird()
        {
            Thread.Sleep(1000);
            Console.WriteLine("SingletonSecond(): 初始化实例");
        }

        public static SingletonThird getInstance()
        {
            return instance;
        }

        public void doSomething()
        {
            Thread.Sleep(1000);
            Console.WriteLine("调用doSomething()方法;线程编号{0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
