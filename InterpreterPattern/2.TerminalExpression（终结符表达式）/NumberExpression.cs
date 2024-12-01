using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    // 终结符表达式：数字
    public class NumberExpression : Expression
    {
        private int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public override int Interpret()
        {
            return _number;
        }
    }
}
