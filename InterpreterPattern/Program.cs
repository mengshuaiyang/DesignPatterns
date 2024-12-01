using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 构建表达式：(3 + 4) * 5
            Expression expression = new MultiplyExpression(
                new AddExpression(
                    new NumberExpression(3),
                    new NumberExpression(4)
                ),
                new NumberExpression(5)
            );

            int result = expression.Interpret();
            Console.WriteLine("Result: " + result); // 输出结果：(3 + 4) * 5 = 35
        }
    }
}
