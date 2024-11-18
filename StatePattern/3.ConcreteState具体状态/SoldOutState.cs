using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class SoldOutState : IState
    {
        private GumballMachineNew gumballMachine; // 引用GumballMachine对象

        // 构造函数，接收GumballMachine对象的引用
        public SoldOutState(GumballMachineNew gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        // 在这个状态下，不允许再次投入25分钱
        public void InsertQuarter()
        {
            Console.WriteLine("请稍等，我们正在给你一个糖果。");
        }

        // 在这个状态下，不允许退回25分钱，因为糖果正在分发中
        public void EjectQuarter()
        {
            Console.WriteLine("抱歉，你已经转动了曲柄。");
        }

        // 在这个状态下，转动曲柄不会得到额外的糖果
        public void TurnCrank()
        {
            Console.WriteLine("转动两次并不能得到另一个糖果！");
        }

        // 分发糖果，检查糖果机中是否还有糖果
        public void Dispense()
        {
            gumballMachine.ReleaseBall(); // 释放一个糖果
            if (gumballMachine.GetCount() > 0)
            {
                // 如果还有糖果，保持在NoQuarterState状态
                gumballMachine.SetState(new NoQuarterState(gumballMachine));
            }
            else
            {
                // 如果没有糖果，转换到SoldOutState状态
                Console.WriteLine("哎呀，没有糖果了！");
                gumballMachine.SetState(new SoldState(gumballMachine));
            }
        }
    }
}
