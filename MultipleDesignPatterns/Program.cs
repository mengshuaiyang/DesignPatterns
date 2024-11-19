using MultipleDesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //通过抽象工厂创建对象
            AbstractDuckFactory duckFactory = new DuckCounterFactory();
            AbstractGooseFactory gooseFactory = new GooseFactory();
            // 创建一个模拟器实例
            DuckSimulator simulator = new DuckSimulator();
            // 调用模拟方法
            simulator.Simulate(duckFactory, gooseFactory);

            Console.Read();
        }
    }
}
