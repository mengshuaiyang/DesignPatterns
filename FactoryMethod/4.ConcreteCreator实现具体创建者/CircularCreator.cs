using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CircularCreator : ICreator
    {
        public override IShape CreateShape()
        {
            return new Circular();
        }
    }
}
