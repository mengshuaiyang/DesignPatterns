using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPattern
{
    [Serializable]
    public class ConcretePrototypeDeep : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Other ClassInfo { get; set; }

        public object Clone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream);
        }

        public void GetUserInfo()
        {
            Console.WriteLine("Name:{0} - Age:{1},ClassId {2} ClassName {3}", Name, Age, ClassInfo.Id, ClassInfo.ClassName);
        }
    }
}
