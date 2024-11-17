using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        // 客户端代码
        static void Main(string[] args)
        {
            // 现代家具工厂
            FurnitureFactory modernFactory = new ModernFurnitureFactory();
            Sofa modernSofa = modernFactory.CreateSofa();
            Table modernTable = modernFactory.CreateTable();

            modernSofa.Display();
            modernTable.Display();

            // 古典家具工厂
            FurnitureFactory classicFactory = new ClassicFurnitureFactory();
            Sofa classicSofa = classicFactory.CreateSofa();
            Table classicTable = classicFactory.CreateTable();

            classicSofa.Display();
            classicTable.Display();

            Console.ReadKey();
        }
    }
}
