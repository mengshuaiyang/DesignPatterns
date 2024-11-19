using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    internal class IteratorObserverShelf : IteratorObserver
    {
        private ArrayList _observers;
        private int _current = 0;

        public IteratorObserverShelf(ArrayList observers)
        {
            _observers = observers;
        }

        public bool HasNext()
        {
            return _current < _observers.Count;
        }

        public Observer Next()
        {
            Observer observer = _observers[_current] as Observer;
            _current++;
            return observer;
        }
    }
}