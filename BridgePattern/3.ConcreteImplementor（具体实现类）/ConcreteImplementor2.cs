using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 实现Implementor接口的具体类。
    /// </summary>
    public class ConcreteImplementor2 : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("第二种具体实现方法");
        }
    }
}
