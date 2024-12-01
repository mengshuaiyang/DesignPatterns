using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors.Fly
{
    /// <summary>
    /// 具体策略
    /// 实现策略接口的具体算法
    /// </summary>
    internal class Fly : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("这是一个普通的飞行动作");
        }
    }
}
