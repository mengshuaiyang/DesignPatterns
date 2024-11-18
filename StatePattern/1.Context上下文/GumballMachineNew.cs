using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class GumballMachineNew
    {
        IState soldOutState; // 售罄状态
        IState noQuarterState; // 没有25分钱状态
        IState hasQuarterState; // 有25分钱状态
        IState soldState; // 正在出售糖果状态
        IState winnerState; //

        IState state; // 当前状态初始化为售罄状态
        int count = 0; // 糖果数量

        // 构造函数，初始化糖果机的状态和数量
        public GumballMachineNew(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            this.count = numberGumballs;
            if (numberGumballs > 0)
            {
                state = noQuarterState; // 如果有糖果，初始化状态为没有25分钱状态
            }
        }

        // 插入25分钱
        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        // 退回25分钱
        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        // 转动曲柄
        public void TurnCrank()
        {
            state.TurnCrank();
        }

        // 分发糖果
        public void Dispense()
        {
            state.Dispense();
        }

        // 设置状态
        public void SetState(IState state)
        {
            this.state = state;
        }

        // 释放一个糖果
        public void ReleaseBall()
        {
            Console.WriteLine("一个糖果从分配口滚出...");
            if (count != 0)
            {
                count--; // 减少糖果数量
            }
        }

        // 获取当前状态
        public string GetState()
        {
            string states = "未知状态";
            switch (state.ToString())
            {
                case "StatePattern.SoldOutState":
                    states = "糖果售罄";
                    break;
                case "StatePattern.NoQuarterState":
                    states = "没有25分钱";
                    break;
                case "StatePattern.HasQuarterState":
                    states = "有25分钱";
                    break;
                case "StatePattern.SoldState":
                    states = "糖果售出";
                    break;
                case "StatePattern.WinnerState":
                    states = "中奖状态";
                    break;
                default:
                    break;
            }
            return $"{states}(糖果数量{count})";
        }

        // 获取糖果数量
        public int GetCount()
        {
            return count;
        }
    }
}
