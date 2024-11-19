using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 代理类，也实现了Image接口，它包含对RealImage的引用，并在调用display()方法时延迟加载图像。
    /// </summary>
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _filename;

        public ProxyImage(string filename)
        {
            _filename = filename;
        }

        public void display()
        {
            Console.WriteLine("记录访问日志");
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }
            _realImage.display();
        }
    }
}
