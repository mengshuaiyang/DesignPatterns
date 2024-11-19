using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    /// <summary>
    /// 文件夹（组合）:组合对象，实现了文件组件接口，并包含一个文件组件的集合。
    /// </summary>
    public class Folder : FileComponent
    {
        private List<FileComponent> _components = new List<FileComponent>();
        private string _name;

        public Folder(string name)
        {
            _name = name;
        }

        public void Add(FileComponent component)
        {
            _components.Add(component);
        }

        public void Remove(FileComponent component)
        {
            _components.Remove(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name + "/");
            foreach (var component in _components)
            {
                component.Display(depth + 2);
            }
        }
    }
}
