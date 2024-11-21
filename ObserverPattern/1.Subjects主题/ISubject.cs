using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 主题接口
    /// </summary>
    internal interface ISubject
    {
        void RegisterObserver(IObserver ob);
        void RemoveObserver(IObserver ob);
        void NotifyObservers();
    }
}
