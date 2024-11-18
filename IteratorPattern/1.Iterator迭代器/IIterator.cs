using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // 迭代器接口
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
