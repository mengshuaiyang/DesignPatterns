using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // 具体工厂：现代家具工厂
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public Sofa CreateSofa()
        {
            return new ModernSofa();
        }

        public Table CreateTable()
        {
            return new ModernTable();
        }
    }
}
