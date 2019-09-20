using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 绘画直线
    /// </summary>
    public class LineShape : Shape
    {
        public void BoundIngBox()
        {
            Console.WriteLine("{0}的BoundIngBox()方法",this.GetType());
        }

        public void CreateManipuator()
        {
            Console.WriteLine("{0}的CreateManipuator()方法", this.GetType());
        }
    }
}
