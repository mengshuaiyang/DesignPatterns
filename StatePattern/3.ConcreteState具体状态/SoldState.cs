using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class SoldState : IState
    {
        private GumballMachineNew gumballMachine; // 引用GumballMachine对象

        // 构造函数，接收GumballMachine对象的引用
        public SoldState(GumballMachineNew gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        // 在售罄状态下，不允许投入25分钱
        public void InsertQuarter()
        {
            Console.WriteLine("你不能投入25分钱，机器已经售罄了。");
        }

        // 如果没有投入25分钱，不能退钱
        public void EjectQuarter()
        {
            Console.WriteLine("你不能退回25分钱，因为你还没有投入25分钱。");
        }

        // 在售罄状态下，转动曲柄不会有任何效果，因为已经没有糖果了
        public void TurnCrank()
        {
            Console.WriteLine("你转动了，但是没有糖果了。");
        }

        // 在售罄状态下，不会分发糖果
        public void Dispense()
        {
            Console.WriteLine("没有糖果可以分发。");
        }
    }
}
