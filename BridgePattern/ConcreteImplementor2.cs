using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ConcreteImplementor2 : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("第二种具体实现方法");
        }
    }
}
