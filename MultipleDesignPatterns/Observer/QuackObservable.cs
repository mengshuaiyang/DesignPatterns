using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 定义一个接口，用于观察者模式，包含注册和通知观察者的方法
    /// </summary>
    public interface QuackObservable
    {
        void RegisterObserver(Observer observer);
        void NotifyObservers();
    }
}
