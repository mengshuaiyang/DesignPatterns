using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    /// <summary>
    /// 组件接口，定义了所有文件和文件夹共有的操作，如delete、display。
    /// </summary>
    public interface FileComponent
    {
        void Add(FileComponent component);
        void Remove(FileComponent component);
        void Display(int depth);
    }
}
