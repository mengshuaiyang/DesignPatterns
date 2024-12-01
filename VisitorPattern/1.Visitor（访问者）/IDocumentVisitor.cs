using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VisitorPattern
{
    /// <summary>
    /// 访问者接口
    /// 
    /// 为每一个 ConcreteElement（具体元素）类声明一个 Visit 操作。
    /// </summary>
    public interface IDocumentVisitor
    {
        void Visit(Paragraph paragraph);
        void Visit(ImageElement image);
    }

}
