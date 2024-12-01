using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// 对象结构
    /// 能枚举元素，可以提供一个高层访问接口，允许访问者访问元素。
    /// </summary>
    public class Document
    {
        private List<IDocumentElement> _elements = new List<IDocumentElement>();

        public void Add(IDocumentElement element)
        {
            _elements.Add(element);
        }

        public void Display(IDocumentVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
