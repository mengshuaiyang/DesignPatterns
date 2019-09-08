namespace OCP
{
    public class NovelBook : IBook
    {
        //书籍名称
        private string Name;

        //书籍的价格
        private int Price;

        //书籍的作者
        private string Author;

        //通过构造函数传递书籍数据
        public NovelBook(string _name, int _price, string _author)
        {
            this.Name = _name;
            this.Price = _price;
            this.Author = _author;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetPrice()
        {
            return Price;
        }
    }
}