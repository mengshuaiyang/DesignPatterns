using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class YCDisplay : IDisplayElement, IObserver
    {
        ISubject subject;
        private string Str;

        public YCDisplay(ISubject _subject)
        {
            subject = _subject;
            subject.RegisterObserver(this);
        }
        public void Diaplay()
        {
            Console.WriteLine($"我是预测输出显示，数据变化了：{Str}");
        }

        public void Update(string change)
        {
            Str = change;
            Diaplay();
        }
    }
}