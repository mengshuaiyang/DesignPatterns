using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1587
/// <summary>
/// 开闭原则:软件实体应该对扩展开放，对修改关闭
/// 
/// </summary>
#pragma warning restore 1587

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            //模拟书店买书
            Console.WriteLine("-----------书店卖出去的书籍记录如下：-----------");
            BindBookInfo();
        }

        private static void BindBookInfo()
        {
            foreach (var novelBook in BookStore.bookList)
            {
                Console.WriteLine("书籍名称：" + novelBook.GetName() + "\t书籍作者：" + novelBook.GetAuthor() + "\t书籍价格：" +string.Format("￥{0}", (novelBook.GetPrice()/ 100.0))  + "元");
            }
        }
    }
}
