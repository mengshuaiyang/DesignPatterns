using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyPattern2
{
    /// <summary>
    /// 具体原型
    /// 实现克隆接口，负责创建自己的副本。
    /// </summary>
    public class Graphic : IPrototype
    {
        public string Property { get; set; }

        public Graphic(string property)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread.Sleep(3000);
            stopwatch.Stop();
            Console.WriteLine("构造函数创建实例消耗时间{0}", stopwatch.ElapsedMilliseconds);
            Property = property;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
