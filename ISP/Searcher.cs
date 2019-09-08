using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Searcher : AbstractSearcher
    {
        public Searcher(IGoodBodyGirl _goodBodyGirl):base(_goodBodyGirl)
        {
            goodBodyGirl = _goodBodyGirl;
        }

        public Searcher(IGreatTemperamentGirl _greatTemperamentGirl) : base(_greatTemperamentGirl)
        {
            greatTemperamentGirl = _greatTemperamentGirl;
        }

        public override void show(IGoodBodyGirl goodBodyGirl)
        {
            Console.WriteLine("--------身材型美女的信息如下：---------------");
            goodBodyGirl.goodLooking();
            goodBodyGirl.niceFigure();
        }

        public override void show(IGreatTemperamentGirl greatTemperamentGirl)
        {
            Console.WriteLine("--------气质型美女的信息如下：---------------");
            greatTemperamentGirl.greatTemperament();
        }
    }
}
