using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        /// <summary>
        /// 单例模式：确保某一个类只有一个实例，而且自行实例化并向整个系统提供这个实例。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<Task> tasks = new List<Task>();
            TaskFactory taskFactory = new TaskFactory();
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(taskFactory.StartNew(() =>
                {
                    SingletonSecond.getInstance().doSomething();
                }));
            }
            Task.WaitAll(tasks.ToArray());

            //for (int i = 0; i < 10; i++)
            //{
            //    tasks.Add(taskFactory.StartNew(() =>
            //    {
            //        SingletonBug.getInstance().doSomething();
            //    }));
            //}
            //Task.WaitAll(tasks.ToArray());

            stopwatch.Stop();
            Console.WriteLine("一共耗时 {0}毫秒", stopwatch.ElapsedMilliseconds);

            //Singleton singleton1 = Singleton.getInstance();
            //Singleton singleton2 = Singleton.getInstance();
            //Console.WriteLine(singleton1 == singleton2);


            Console.ReadKey();
        }
    }
}
