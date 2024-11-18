using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    // 具体工厂：古典家具工厂
    public class ClassicFurnitureFactory : FurnitureFactory
    {
        public Sofa CreateSofa()
        {
            return new ClassicSofa();
        }

        public Table CreateTable()
        {
            return new ClassicTable();
        }
    }
}
