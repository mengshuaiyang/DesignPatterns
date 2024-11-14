using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class RectangleFactory: ICreator
    {
        public IShape CreateShape()
        {
            return new Rectangle();
        }
    }
}
