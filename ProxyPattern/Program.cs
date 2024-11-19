using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProxyImage proxyImage = new ProxyImage("我是一只鱼");
            proxyImage.display();
            proxyImage = new ProxyImage("我是一只鸟");
            proxyImage.display();
            Console.ReadKey();
        }
    }
}
