using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 用**适配器模式**，将鹅适配成Quackable
    /// </summary>
    public class GoosesAdapter : Quackable
    {
        Observable _observable;
        Gooses gooses;

        public GoosesAdapter(Gooses gooses)
        {
            this.gooses = gooses;
            _observable = new Observable(this);
        }

        public void Quack()
        {
            gooses.Huck();
            NotifyObservers();
        }

        public void RegisterObserver(Observer observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }
}
