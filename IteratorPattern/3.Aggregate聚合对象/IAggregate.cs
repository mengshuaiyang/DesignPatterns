using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // 聚合对象接口
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
