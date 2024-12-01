using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// 元素接口
    /// 定义一个 Accept 操作，该操作以一个访问者对象作为参数。
    /// </summary>
    public interface IDocumentElement
    {
        void Accept(IDocumentVisitor visitor);
    }
}
