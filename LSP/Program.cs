using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///里氏替换原则（Liskov Substitution Principle，LSP）
///1.子类必须完全实现父类的方法
///2.子类可以有自己的个性
///3.覆盖或实现父类的方法时输入参数可以被放大
///4. 覆写或实现父类的方法时输出结果可以被缩小

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生三毛这个士兵
            Soldier sanMao = new Soldier();
            //给三毛一支枪
            sanMao.setGun(new ToyGun());
            sanMao.killEnemy();

            //产生李四这个士兵
            Soldier liSi = new Soldier();
            //给李四一把机枪
            liSi.setGun(new AUG());
            liSi.killEnemy();
            Console.ReadKey();
        }
    }
}
