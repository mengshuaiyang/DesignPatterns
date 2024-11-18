using IteratorPattern._4.ConcreteAggregate具体聚合对象;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf();
            IIterator iteratorBook = bookShelf.CreateIterator();
            while (iteratorBook.HasNext())
            {
                Console.WriteLine(iteratorBook.Next());
            }

            MusicShelf musicShelf = new MusicShelf();
            IIterator iteratorMusic= musicShelf.CreateIterator();
            while (iteratorMusic.HasNext())
            {
                Console.WriteLine(iteratorMusic.Next());
            }

            ViedoShelf viedoShelf = new ViedoShelf();
            IIterator iteratorVideo = viedoShelf.CreateIterator();
            while (iteratorVideo.HasNext())
            {
                Console.WriteLine(iteratorVideo.Next());
            }

            Console.ReadKey();
        }
    }
}
