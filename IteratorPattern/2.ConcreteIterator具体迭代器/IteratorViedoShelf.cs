using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // 具体迭代器
    public class IteratorViedoShelf : IIterator
    {
        private ArrayList _videos;
        private int _current = 0;

        public IteratorViedoShelf(ArrayList videos)
        {
            _videos = videos;
        }

        public bool HasNext()
        {
            return _current < _videos.Count;
        }

        public object Next()
        {
            string viedo = (string)_videos[_current];
            _current++;
            return viedo;
        }
    }
}
