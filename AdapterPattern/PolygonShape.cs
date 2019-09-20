using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 绘画多边形
    /// </summary>
    public class PolygonShape:Shape
    {
        public void BoundIngBox()
        {
            Console.WriteLine("{0}的BoundIngBox()方法", this.GetType());
        }

        public void CreateManipuator()
        {
            Console.WriteLine("{0}的CreateManipuator()方法", this.GetType());
        }
    }
}
