using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public interface IDriver
    {
        //车辆型号
        void setCar(ICar car);

        //是司机就应该会驾驶汽车
        void drive();
    }
}
