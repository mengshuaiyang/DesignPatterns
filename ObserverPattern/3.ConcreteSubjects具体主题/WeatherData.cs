using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 数据源（当数据源改变时，应该通知所有订阅者）
    /// </summary>
    internal class WeatherData : ISubject
    {
        private ArrayList observers;
        private string Change;

        public WeatherData()
        {
            observers = new ArrayList();
        }
        
        public void RegisterObserver(IObserver ob)
        {
            observers.Add(ob);
        }

        public void RemoveObserver(IObserver ob)
        {
            //int index = observers.IndexOf(ob);
            //if (index >= 0)
            //{
            //    observers.RemoveAt(index);
            //}

            observers.Remove(ob);
        }

        public void NotifyObservers()
        {
            //for (int i = 0; i < observers.Count; i++)
            //{
            //    IObserver observer = (IObserver)observers[0];
            //    observer.Update(Change);
            //}

            foreach (var item in observers)
            {
                IObserver observer = (IObserver)item;
                observer.Update(Change);
            }
        }

        public void Changed()
        {
            NotifyObservers(); 
        }

        public void SetChange(string info)
        {
            Change=info;
            Changed();
        }
    }
}
