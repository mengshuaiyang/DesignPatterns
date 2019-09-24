using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new AbstractionImpl();

            ab.SetImplementor(new ConcreteImplementor1());
            ab.Operation();

            ab.SetImplementor(new ConcreteImplementor2());
            ab.Operation();

            Console.ReadKey();
        }
    }
}
