using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 扩展Abstraction类，添加额外的功能。
    /// </summary>
    public class AbstractionImpl : Abstraction
    {
        protected Implementor _implementor;

        public override void SetImplementor(Implementor implementor)
        {
            this._implementor = implementor;
        }

        public override void Operation()
        {
            _implementor.Operation();
        }
    }
}
