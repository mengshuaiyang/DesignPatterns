using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    /// <summary>
    /// 叶子对象，实现了文件组件接口。
    /// </summary>
    public class File : FileComponent
    {
        private string _name;

        public File(string name)
        {
            _name = name;
        }

        public void Add(FileComponent component)
        {
            throw new NotImplementedException();
        }

        public void Remove(FileComponent component)
        {
            throw new NotImplementedException();
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name);
        }
    }
}
