using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 图像对象的接口(Target)
    /// </summary>
    public interface Shape
    {
        void BoundIngBox();
        void CreateManipuator();
    }
}
