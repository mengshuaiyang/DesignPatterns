using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //浅克隆
            ConcretePrototype cp = new ConcretePrototype();
            cp.Name = "学生1";
            cp.Age = 19;
            cp.ClassInfo = new Other { Id = 1, ClassName = "一班" };
            cp.GetUserInfo();

            ConcretePrototype cp2 = cp.Clone() as ConcretePrototype;
            cp2.Age = 20;
            cp2.ClassInfo.Id = 2;
            cp2.ClassInfo.ClassName = "二班";
            cp.GetUserInfo();
            cp2.GetUserInfo();

            //深克隆
            ConcretePrototypeDeep cpd = new ConcretePrototypeDeep();
            cpd.Name = "学生2";
            cpd.Age = 19;
            cpd.ClassInfo =new Other { Id = 1 , ClassName = "一班" };
            cpd.GetUserInfo();

            ConcretePrototypeDeep cpd2 = cpd.Clone() as ConcretePrototypeDeep;
            cpd2.Age = 20;
            cpd2.ClassInfo.Id = 2;
            cpd2.ClassInfo.ClassName = "二班";
            cpd.GetUserInfo();
            cpd2.GetUserInfo();

            Console.ReadKey();
        }
    }
}
