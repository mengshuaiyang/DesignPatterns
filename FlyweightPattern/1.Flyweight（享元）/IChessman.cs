using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    // 享元接口
    public interface IChessman
    {
        void Place(int x, int y);
    }
}
