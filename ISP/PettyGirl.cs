using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    //美女类
    public class PettyGirl : IGoodBodyGirl, IGreatTemperamentGirl
    {
        private String name;
        //美女都有名字

        public PettyGirl(String _name)
        {
            this.name = _name;
        }

        void IGoodBodyGirl.goodLooking()
        {
            Console.WriteLine(this.name + "---脸蛋很漂亮!");
        }

        void IGreatTemperamentGirl.greatTemperament()
        {
            Console.WriteLine(this.name + "---气质非常好!");
        }

        void IGoodBodyGirl.niceFigure()
        {
            Console.WriteLine(this.name + "---身材非常棒!");
        }
    }
}
