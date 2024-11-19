using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FileComponent file = new Folder("文件夹1");
            FileComponent file2 = new Folder("文件夹2");
            FileComponent file3 = new File("文件1");
            FileComponent file4 = new Folder("文件夹3");
            FileComponent file5 = new File("文件2");
            file.Add(file2);
            file2.Add(file3);
            file2.Add(file4);
            file4.Add(file5);

            file.Display(0);

            file2.Remove(file3);

            file.Display(0);

            Console.ReadKey();
        }
    }
}
