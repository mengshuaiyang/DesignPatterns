using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 备忘录管理者
    /// </summary>
    public class Caretaker
    {
        private TextMemento _mementos;

        public void SetMemento(TextMemento memento)
        {
            _mementos=memento;
        }

        public TextMemento GetMemento()
        {
            return _mementos;
        }
    }
}
