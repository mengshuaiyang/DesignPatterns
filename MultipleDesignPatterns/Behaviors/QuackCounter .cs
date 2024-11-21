using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// QuackCounter是一个装饰者，用于计数鸭子的叫声
    /// </summary>
    public class QuackCounter : Quackable
    {
        private Quackable _duck; // 用于记录被装饰的鸭子
        private static int _numberOfQuacks = 0; // 静态变量，用于跟踪所有鸭子的叫声次数

        // 构造函数，传入一个Quackable对象
        public QuackCounter(Quackable duck)
        {
            _duck = duck;
        }

        // 实现Quackable接口的Quack方法
        public void Quack()
        {
            _duck.Quack(); // 调用被装饰的鸭子的Quack方法
            _numberOfQuacks++; // 每次调用时，叫声次数加一
            //NotifyObservers();
        }

        // 静态方法，用于获取所有鸭子的叫声次数
        public static int GetQuacks()
        {
            return _numberOfQuacks;
        }
        public void RegisterObserver(Observer observer)
        {
            _duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _duck.NotifyObservers();
        }
    }
}
