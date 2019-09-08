using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class BookStore
    {
        public static List<IBook> bookList = new List<IBook>()
        {
            new OffNovelBook("天龙八部", 3200, "金庸"),
            new OffNovelBook("巴黎圣母院", 5600, "雨果"),
            new OffNovelBook("金瓶梅", 4300, "兰陵笑笑生")
        };

    }
}