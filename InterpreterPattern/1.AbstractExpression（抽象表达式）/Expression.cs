using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    // 抽象表达式
    public abstract class Expression
    {
        public abstract int Interpret();
    }
}
