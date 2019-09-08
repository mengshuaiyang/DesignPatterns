﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        public static Singleton instance;

        public static object Singleton_Lock=new object();
        private Singleton()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Singleton(): 初始化实例");
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                lock (Singleton_Lock)
                {
                    Thread.Sleep(1000);
                    if (instance == null)
                    {
                        Console.WriteLine("getInstance(): 第一次调用getInstance();线程编号{0}", Thread.CurrentThread.ManagedThreadId);
                        instance = new Singleton();
                    }
                }
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
