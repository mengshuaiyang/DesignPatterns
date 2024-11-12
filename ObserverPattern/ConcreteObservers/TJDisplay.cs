using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class TJDisplay : IDisplayElement, IObserver
    {
        ISubject subject;
        private string Str;

        public TJDisplay(ISubject _subject)
        {
            subject = _subject;
            subject.RegisterObserver(this);
        }

        public void Diaplay()
        {
            Console.WriteLine($"我是统计输出显示，数据变化了：{Str}");
        }

        public void Update(string change)
        {
            Str=change;
            Diaplay();
        }
    }
}
