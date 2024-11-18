using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern._4.ConcreteAggregate具体聚合对象
{
    public class MusicShelf
    {
        private string[] _musics;

        public MusicShelf()
        {
            _musics = new string[] { "音乐1", "音乐2", "音乐3", "音乐4", "音乐5" };
        }

        public IIterator CreateIterator()
        {
            return new IteratorMusicShelf(_musics);
        }
    }
}
