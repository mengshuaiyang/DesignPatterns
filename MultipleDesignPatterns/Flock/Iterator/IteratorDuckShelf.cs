using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    public class IteratorDuckShelf : Iterator
    {
        private List<Quackable> _ducks;
        private int _current = 0;

        public IteratorDuckShelf(List<Quackable> ducks)
        {
            _ducks = ducks;
        }

        public bool HasNext()
        {
            return _current < _ducks.Count;
        }

        public Quackable Next()
        {
            Quackable quackable = _ducks[_current];
            _current++;
            return quackable;
        }
    }
}
