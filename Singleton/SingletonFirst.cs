using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 双重检查锁定模式
    /// </summary>
    public class SingletonFirst
    {
        public static SingletonFirst instance;

        public static object Singleton_Lock=new object();

        private static int i = 10;
        private SingletonFirst()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Singleton(): 初始化实例");
        }

        public static SingletonFirst getInstance()
        {
            if (instance == null)
            {
                lock (Singleton_Lock)
                {
                    Thread.Sleep(1000);
                    if (instance == null)
                    {
                        Console.WriteLine("getInstance(): 第一次调用getInstance();线程编号{0}", Thread.CurrentThread.ManagedThreadId);
                        instance = new SingletonFirst();
                    }
                }
            }

            return instance;
        }

        public void doSomething()
        {
            Thread.Sleep(1000);
            Console.WriteLine("调用doSomething()方法;线程编号{0} i={1}", Thread.CurrentThread.ManagedThreadId,i--);
        }
    }
}
