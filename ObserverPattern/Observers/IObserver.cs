using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    internal interface IObserver
    {
        void Update(string change);
    }
}
