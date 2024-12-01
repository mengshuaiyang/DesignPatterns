using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            editor.Type("Hello, World!");
            Console.WriteLine(editor.GetText()); // 输出: Hello, World!

            TextMemento save = editor.Save(); // 保存当前状态

            editor.Type("Example");
            Console.WriteLine(editor.GetText()); // 输出: Hello, World! Example

            editor.Restore(save); // 恢复到保存的状态
            Console.WriteLine(editor.GetText()); // 输出: Hello, World!

            Console.ReadKey();
        }
    }
}
