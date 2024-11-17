using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // 抽象工厂接口：家具工厂
    public interface FurnitureFactory
    {
        Sofa CreateSofa();
        Table CreateTable();
    }

}
