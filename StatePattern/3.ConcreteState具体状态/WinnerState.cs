using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class WinnerState : IState
    {
        private GumballMachineNew gumballMachine; // 引用GumballMachine对象

        // 构造函数，接收GumballMachine对象的引用
        public WinnerState(GumballMachineNew gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        // 在中奖状态下，不允许再次投入25分钱
        public void InsertQuarter()
        {
            Console.WriteLine("请稍等，我们正在给你一个糖果。");
        }

        // 在中奖状态下，不允许退回25分钱
        public void EjectQuarter()
        {
            Console.WriteLine("抱歉，你已经转动了曲柄。");
        }

        // 在中奖状态下，转动曲柄不会得到额外的糖果
        public void TurnCrank()
        {
            //Console.WriteLine("转动两次并不能得到另一个糖果！");

            Dispense();
        }

        // 分发糖果，检查糖果机中是否还有糖果
        public void Dispense()
        {
            Console.WriteLine("你是一个赢家！你投入的25分钱可以得到两个糖果！");
            gumballMachine.ReleaseBall(); // 释放一个糖果
            if (gumballMachine.GetCount() == 0)
            {
                gumballMachine.SetState(new SoldOutState(gumballMachine)); // 如果没有糖果了，转换到售罄状态
            }
            else
            {
                gumballMachine.ReleaseBall(); // 再释放一个糖果
                if (gumballMachine.GetCount() > 0)
                {
                    gumballMachine.SetState(new NoQuarterState(gumballMachine)); // 如果还有糖果，转换到没有25分钱状态
                }
                else
                {
                    Console.WriteLine("哎呀，没有糖果了！");
                    gumballMachine.SetState(new SoldState(gumballMachine)); // 没有糖果了，转换到售罄状态
                }
            }
        }
    }
}
