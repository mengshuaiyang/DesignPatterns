using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class BookShelf : IAggregate
    {
        private List<string> _books;

        public BookShelf()
        {
            _books = new List<string>();
            _books.Add("书1");
            _books.Add("书2");
            _books.Add("书3");
        }

        //public void AddBook(string book)
        //{
        //    _books.Add(book);
        //}

        public IIterator CreateIterator()
        {
            return new IteratorBookShelf(_books);
        }
    }
}
