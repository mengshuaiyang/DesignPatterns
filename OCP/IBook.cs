namespace OCP
{
    public interface IBook
    {
        //书籍有名称
        string GetName();
        //书籍有售价
        int GetPrice();
        //书籍有作者
        string GetAuthor();
    }
}