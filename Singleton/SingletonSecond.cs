using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 静态构造函数（static构造函数）来实现单例模式
    /// </summary>
    public class SingletonSecond
    {
        public static SingletonSecond instance;

        private SingletonSecond()
        {
            Thread.Sleep(1000);
            Console.WriteLine("SingletonSecond(): 初始化实例");
        }

        static SingletonSecond()//CLR运行时候  第一次使用这个类之前，一定会而且只会执行一次
        {
            Thread.Sleep(1000);
            Console.WriteLine("getInstance(): 第一次调用getInstance();线程编号{0}", Thread.CurrentThread.ManagedThreadId);
            instance = new SingletonSecond();
        }

        public static SingletonSecond getInstance()
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
