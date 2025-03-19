using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ShapeFactory : ICreatorYH
    {
        public override T CreateShape<T>(Type type)
        {
            // 定义一个生产的人种
            IShape shape = null;
            try
            {
                // 产生一个人种
                shape = (T)Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Console.WriteLine("生成错误！" + e.Message);
            }
            return (T)shape;
        }
    }
}
