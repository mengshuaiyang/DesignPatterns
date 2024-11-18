using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class HasQuarterState : IState
    {
        private Random randomWinner = new Random(DateTime.Now.Millisecond); // 随机数生成器，用于决定中奖
        private GumballMachineNew gumballMachine; // 引用GumballMachine对象

        // 构造函数，接收GumballMachine对象的引用
        public HasQuarterState(GumballMachineNew gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        // 尝试再次投入25分钱，但因为已经有25分钱了，所以不允许
        public void InsertQuarter()
        {
            Console.WriteLine("你不能再次投入25分钱。");
           
        }

        // 退回25分钱，并转换到没有25分钱的状态
        public void EjectQuarter()
        {
            Console.WriteLine("退回了25分钱。");
            gumballMachine.SetState(new NoQuarterState(gumballMachine));
        }

        // 转动曲柄，如果糖果机中有糖果，则分发糖果并转换到没有25分钱的状态
        public void TurnCrank()
        {
            Console.WriteLine("你转动了曲柄...");
            int winner = randomWinner.Next(10); // 随机生成0到9之间的数字，模拟10%的中奖机会
            if (winner == 0 && gumballMachine.GetCount() > 1)
            {
                gumballMachine.SetState(new WinnerState(gumballMachine)); // 中奖，进入WinnerState状态
            }
            else if (gumballMachine.GetCount() > 0)
            {
                gumballMachine.ReleaseBall();
                Console.WriteLine("一个糖果分发中...");
                gumballMachine.SetState(new NoQuarterState(gumballMachine));
            }
            else
            {
                Console.WriteLine("没有更多的糖果了。");
                gumballMachine.SetState(new SoldState(gumballMachine));
            }
        }

        // 分发糖果，但因为已经投入了25分钱，所以不需要再次分发
        public void Dispense()
        {
            Console.WriteLine("不需要再次分发糖果，已经投入了25分钱。");
        }
    }
}
