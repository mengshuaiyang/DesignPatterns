using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 橡皮鸭
    /// </summary>
    public class RubberDuck : Quackable
    {
        public void Quack()
        {
            Console.WriteLine("橡皮鸭：吱吱叫");
        }
    }
}
