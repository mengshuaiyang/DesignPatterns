﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    // 迭代器接口
    public interface IteratorObserver
    {
        bool HasNext();
        Observer Next();
    }
}
