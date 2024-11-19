using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 抽象的可观察类，实现了QuackObservable接口
    /// </summary>
    public abstract class Observable : QuackObservable
    {
        protected ArrayList observers = new ArrayList(); // 用于存储观察者列表
        protected QuackObservable duck; // 用于存储被观察的对象

        // 构造函数，传入一个QuackObservable对象
        public Observable(QuackObservable duck)
        {
            this.duck = duck;
        }

        // 注册观察者的方法
        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }

        // 通知观察者的方法
        public void NotifyObservers()
        {
            IteratorObserver iterator = new IteratorObserverShelf(observers); // 获取观察者列表的枚举器
            while (iterator.HasNext()) // 遍历观察者列表
            {
                Observer observer = (Observer)iterator.Next(); // 获取当前观察者
                observer.Update(duck); // 通知观察者
            }
        }
    }
}
