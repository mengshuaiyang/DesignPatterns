using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors
{
    /// <summary>
    /// 策略接口
    /// 定义所有支持的算法的公共接口。
    /// </summary>
    public interface FlyBehavior
    {
        void fly();
    }
}
