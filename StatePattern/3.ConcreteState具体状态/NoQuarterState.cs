using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class NoQuarterState:IState
    {
        private GumballMachineNew gumballMachine; // 引用GumballMachine对象

        // 构造函数，接收GumballMachine对象的引用
        public NoQuarterState(GumballMachineNew gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        // 当投入25分钱时，打印消息并转换到HasQuarterState状态
        public void InsertQuarter()
        {
            Console.WriteLine("你投入了一枚25分钱。");
            gumballMachine.SetState(new HasQuarterState(gumballMachine));
        }

        // 如果没有投入25分钱，不能退钱
        public void EjectQuarter()
        {
            Console.WriteLine("你没有投入25分钱。");
        }

        // 如果没有投入25分钱，转动曲柄不会得到糖果
        public void TurnCrank()
        {
            Console.WriteLine("你转动了，但是没有25分钱。");
        }

        // 如果没有投入25分钱，不能得到糖果
        public void Dispense()
        {
            Console.WriteLine("你需要先付钱。");
        }
    }
}
