using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 包含一个指向实现类的引用，并定义可能依赖于实现的具体方法。
    /// </summary>
    public abstract class Abstraction
    {
        public abstract void SetImplementor(Implementor implementor);
        public abstract void Operation();

    }
}
