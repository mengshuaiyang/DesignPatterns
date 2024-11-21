using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 把所有创建对象集合到一起
    /// Flock类实现了Quackable接口，表示一群鸭子
    /// </summary>
    public class Flock : Quackable
    {
        private List<Quackable> quackers = new List<Quackable>(); // 用于存储群体中的Quackable对象

        // 添加Quackable对象到群体中
        public void Add(Quackable quacker)
        {
            quackers.Add(quacker);
        }

        // 实现Quackable接口的Quack方法，让群体中的所有鸭子都叫
        public void Quack()
        {
            //这里使用迭代器模式获取数据
            Iterator iterator = new IteratorDuckShelf(quackers);
            while (iterator.HasNext())
            {
                Quackable quackable = (Quackable)iterator.Next();
                quackable.Quack();
                //NotifyObservers();
            }
            //foreach (var quacker in quackers)
            //{
            //    quacker.Quack();
            //}
        }
        public void RegisterObserver(Observer observer)
        {
            //这里使用迭代器模式注册
            Iterator iterator = new IteratorDuckShelf(quackers);
            while (iterator.HasNext())
            {
                Quackable quackable = (Quackable)iterator.Next();
                quackable.RegisterObserver(observer);
            }
           
        }

        public void NotifyObservers()
        {
            //Console.WriteLine("Flock 的通知");
        }
    }
}
