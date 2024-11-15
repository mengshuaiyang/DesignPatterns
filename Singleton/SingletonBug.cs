using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 单例模式的简单实现（多线程有问题）
    /// </summary>
    public class SingletonBug
    {
        public static SingletonBug instance;

        private SingletonBug()
        {
            Thread.Sleep(1000);
            Console.WriteLine("SingletonFour(): 初始化实例");
        }

        public static SingletonBug getInstance()
        {
            if (instance == null)
            {
                Console.WriteLine("getInstance(): 第一次调用getInstance();线程编号{0}", Thread.CurrentThread.ManagedThreadId);
                instance = new SingletonBug();
            }

            return instance;
        }

        public void doSomething()
        {
            Thread.Sleep(1000);
            Console.WriteLine("调用doSomething()方法;线程编号{0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
