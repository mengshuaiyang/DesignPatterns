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
            ////第一种实现方式
            //TextEditor editor = new TextEditor();
            //editor.Type("Hello, World!");
            //Console.WriteLine(editor.GetText()); // 输出: Hello, World!

            //TextMemento save = editor.Save(); // 保存当前状态

            //editor.Type("Example");
            //Console.WriteLine(editor.GetText()); // 输出: Hello, World! Example

            //editor.Restore(save); // 恢复到保存的状态
            //Console.WriteLine(editor.GetText()); // 输出: Hello, World!


            //第二种实现方式
            TextEditor editorOther = new TextEditor();
            Caretaker caretaker= new Caretaker();

            editorOther.Type("Hello, World!");
            caretaker.SetMemento(editorOther.Save()); // 保存当前状态

            editorOther.Type("Example");
            Console.WriteLine(editorOther.GetText()); // 输出: Hello, World! Example

            editorOther.Restore(caretaker.GetMemento()); // 恢复到保存的状态

            Console.WriteLine(editorOther.GetText()); // 输出: Hello, World! Example

            Console.ReadKey();
        }
    }
}
