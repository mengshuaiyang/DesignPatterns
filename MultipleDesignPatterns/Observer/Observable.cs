using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 现在我们必须确定所有实现Quackable的具体类都能够扮演QuackObservable的角色。
    /// 我们需要在每一个类中实现注册和通知。但是这次我们要用稍微不一样的做法:
    /// 我们要在另一个被称为Observable的类中封装注册和通知的代码，然后将它和QuackObservable组合在一起。
    /// 这样，我们只需要一份代码即可，QuackObservable所有的调用都委托给Observable辅助类。
    /// 我们先从Observablc辅助类开始下手吧…
    /// </summary>
    public class Observable : QuackObservable
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
