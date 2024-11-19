using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 定义一个接口，用于观察者
    /// </summary>
    public interface Observer
    {
        void Update(QuackObservable quackObservable);
    }
}
