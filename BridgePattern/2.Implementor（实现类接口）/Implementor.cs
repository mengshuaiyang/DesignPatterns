using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 定义实现类的接口，但不实现它，由具体实现类来实现。
    /// </summary>
    public abstract class Implementor
    {
       public abstract void Operation();
    }
}
