using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 接口隔离原则
/// 1.接口要尽量小
/// 2.接口要高内聚
/// 3.定制服务
/// 4.接口设计是有限度的
/// </summary>

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个身材型美女
            IGoodBodyGirl yanYan = new PettyGirl("嫣嫣");
            AbstractSearcher searcher = new Searcher(yanYan);
            searcher.show(yanYan);

            //定义一个气质型美女
            IGreatTemperamentGirl jingJing = new PettyGirl("静静");
            AbstractSearcher searcher1 = new Searcher(jingJing);
            searcher.show(jingJing);
        }
    }
}
