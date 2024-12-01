using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// 具体元素Paragraph
    /// 实现 Accept 操作。
    /// </summary>
    public class Paragraph : IDocumentElement
    {
        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
