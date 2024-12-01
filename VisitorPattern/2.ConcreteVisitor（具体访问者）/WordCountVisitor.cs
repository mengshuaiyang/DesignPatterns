using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VisitorPattern
{
    /// <summary>
    /// 具体访问者
    /// 
    /// 实现每个以 Visit 操作的方法，定义对每个元素类的操作。
    /// </summary>
    public class WordCountVisitor : IDocumentVisitor
    {
        public void Visit(Paragraph paragraph)
        {
            Console.WriteLine("计算段落字数");
        }

        public void Visit(ImageElement image)
        {
            Console.WriteLine("计算图片相关字数");
        }
    }
}
