using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPattern2
{
    /// <summary>
    /// 原型接口
    /// 定义了一个克隆自身的接口。
    /// </summary>
    public interface IPrototype
    {
        object Clone();
    }
}
