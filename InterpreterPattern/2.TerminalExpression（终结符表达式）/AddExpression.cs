using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    // 终结符表达式：加法
    public class AddExpression : Expression
    {
        private Expression _left;
        private Expression _right;

        public AddExpression(Expression left, Expression right)
        {
            _left = left;
            _right = right;
        }

        public override int Interpret()
        {
            return _left.Interpret() + _right.Interpret();
        }
    }
}
