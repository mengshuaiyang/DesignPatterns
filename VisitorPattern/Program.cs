using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doc = new Document();
            doc.Add(new Paragraph());
            doc.Add(new ImageElement());

            
            var wordCount = new WordCountVisitor();
            doc.Display(wordCount);

            //当需要对一个对象结构（比如组合结构）中的元素执行操作，而又希望避免修改这些元素的类时
            var highlight = new HighlightVisitor();
            doc.Display(highlight);

            Console.ReadKey();
        }
    }
}
