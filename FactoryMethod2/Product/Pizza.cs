using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;

        public ArrayList toppings=new ArrayList();

        /// <summary>
        /// 准备
        /// </summary>
        public void Prepare()
        {
            Console.ReadLine();
            Console.WriteLine("*************************");
            Console.WriteLine("准备 " + name);

            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine($"添加配料 {toppings[i]}");
            }
        }

        /// <summary>
        /// 烘烤
        /// </summary>
        public virtual void Bake()
        {
            Console.WriteLine($"默认烘烤 2 小时");
        }

        /// <summary>
        /// 切片
        /// </summary>
        public virtual void Cut()
        {
            Console.WriteLine($"默认切片 10 片");
        }

        /// <summary>
        /// 装盒
        /// </summary>
        public void Box()
        {
            Console.WriteLine($"默认装盒 把披萨装盒");
        }

        public string GetName()
        {
            return name;
        }

    }
}
