using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonThird
    {
        public static SingletonThird instance =new SingletonThird();

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
