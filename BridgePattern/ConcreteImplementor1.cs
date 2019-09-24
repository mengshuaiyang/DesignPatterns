using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ConcreteImplementor1 : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("第一种具体实现方法");
        }
    }
}
