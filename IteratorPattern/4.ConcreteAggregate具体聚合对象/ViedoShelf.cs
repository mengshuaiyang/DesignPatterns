using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ViedoShelf
    {
        private ArrayList _videos;

        public ViedoShelf()
        {
            _videos = new ArrayList();

            _videos.Add("The Lion King");
            _videos.Add("The Hobbit");
            _videos.Add("The Godfather");
            _videos.Add("The Dark Knight");
            _videos.Add("The Shawshank Redemption");
        }

        //public void AddVideo(string video)
        //{
        //    _videos.Add(video);
        //}

        public IIterator CreateIterator()
        {
            return new IteratorViedoShelf(_videos);
        }
    }
}
