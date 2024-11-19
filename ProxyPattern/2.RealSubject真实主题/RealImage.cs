using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 真实主题类，实现了Image接口，代表实际的图像对象。
    /// </summary>
    public class RealImage : IImage
    {
        private string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadFromDisk(); // 模拟从磁盘加载
        }

        public void display()
        {
            Console.WriteLine("Displaying " + _filename);
        }

        private void LoadFromDisk()
        {
            Console.WriteLine("Loading " + _filename);
        }
    }
}
