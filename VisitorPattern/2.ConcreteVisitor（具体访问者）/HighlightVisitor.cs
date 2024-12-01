using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VisitorPattern
{
    public class HighlightVisitor : IDocumentVisitor
    {
        public void Visit(Paragraph paragraph)
        {
            Console.WriteLine("高亮段落");
        }

        public void Visit(ImageElement image)
        {
            Console.WriteLine("高亮图片");
        }
    }
}
