using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPattern
{
    public class ConcretePrototype : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Other ClassInfo { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void GetUserInfo()
        {
            Console.WriteLine("Name:{0} - Age:{1},ClassId {2} ClassName {3}", Name, Age, ClassInfo.Id, ClassInfo.ClassName);
        }
    }
}
