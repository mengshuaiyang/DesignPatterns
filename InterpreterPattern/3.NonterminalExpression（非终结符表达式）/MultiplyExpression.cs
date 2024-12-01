using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    // 非终结符表达式：乘法
    public class MultiplyExpression : Expression
    {
        private Expression _left;
        private Expression _right;

        public MultiplyExpression(Expression left, Expression right)
        {
            _left = left;
            _right = right;
        }

        public override int Interpret()
        {
            return _left.Interpret() * _right.Interpret();
        }
    }
}
