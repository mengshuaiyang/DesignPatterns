using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // 具体迭代器
    public class IteratorMusicShelf : IIterator
    {
        private string[] _musics;
        private int _current = 0;

        public IteratorMusicShelf(string[] musics)
        {
            _musics = musics;
        }

        public bool HasNext()
        {
            return _current < _musics.Length;
        }

        public object Next()
        {
            string book = _musics[_current];
            _current++;
            return book;
        }
    }
}
