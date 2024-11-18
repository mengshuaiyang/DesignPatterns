using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SquareCreator: ICreator
    {
        public override IShape CreateShape()
        {
            return new Square();
        }
    }
}
