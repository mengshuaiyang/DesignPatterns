using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 适配器：使TextView能够适配Shape(Adapter)
    /// </summary>
    public class TextShape : TextView, Shape
    {
        public void BoundIngBox()
        {
            base.GetExtent();
        }

        public void CreateManipuator()
        {
            Console.WriteLine("不支持此操作");
        }
    }
}
