namespace OCP
{
    public class OffNovelBook : NovelBook
    {

        private NovelBook novelBook;

        public OffNovelBook(string _name, int _price, string _author) : base(_name, _price, _author)
        {

        }

        public new int GetPrice()
        {
            //原价
            int selfPrice = novelBook.GetPrice();
            int offPrice = 0;
            if (selfPrice > 4000)
            {
                //原价大于40元，则打9折
                offPrice = selfPrice * 50 / 100;
            }
            else
            {
                offPrice = selfPrice * 20 / 100;
            }
            return offPrice;
        }
    }
}