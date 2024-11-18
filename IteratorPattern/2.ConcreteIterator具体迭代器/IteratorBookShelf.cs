using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // 具体迭代器
    public class IteratorBookShelf : IIterator
    {
        private List<string> _books;
        private int _current = 0;

        public IteratorBookShelf(List<string> books)
        {
            _books = books;
        }

        public bool HasNext()
        {
            return _current < _books.Count;
        }

        public object Next()
        {
            string book = _books[_current];
            _current++;
            return book;
        }
    }
}
