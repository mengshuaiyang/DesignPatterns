using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class GumballMachine
    {
        public const int SOLD_OUT = 0; // 糖果售罄
        public const int NO_QUARTER = 1; // 没有25分钱
        public const int HAS_QUARTER = 2; // 有25分钱
        public const int SOLD = 3; // 糖果售出

        private int state = SOLD_OUT; // 初始状态为糖果售罄
        private int count = 0; // 糖果数量

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                state = NO_QUARTER; // 如果有糖果，初始状态为没有25分钱
            }
        }

        public void InsertQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("你不能再放入一个25分钱，机器里已经有了一个。");
            }
            else if (state == NO_QUARTER)
            {
                state = HAS_QUARTER;
                Console.WriteLine("你放入了一个25分钱。");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("你不能放入25分钱，机器已经售罄了。");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("请稍等，我们正在给你一个糖果。");
            }
        }

        public void EjectQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("25分钱已退回。");
                state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("你还没有投入25分钱。");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("对不起，你已经转动了转盘。");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("你不能退回25分钱，因为没有投入。");
            }
        }

        public void TurnCrank()
        {
            if (state == SOLD)
            {
                Console.WriteLine("转了两次，这次不会给你糖果！");
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("你转动了转盘，但是没有投入25分钱。");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("你转动了转盘，但是机器里没有糖果了。");
            }
            else if (state == HAS_QUARTER)
            {
                Console.WriteLine("你转动了转盘...");
                state = SOLD;
                dispense();
            }
        }

        private void dispense()
        {
            if (state == SOLD)
            {
                Console.WriteLine("一个糖果从分配口滚出。");
                count--;
                if (count == 0)
                {
                    Console.WriteLine("哎呀，没有糖果了！");
                    state = SOLD_OUT;
                }
                else
                {
                    state = NO_QUARTER;
                }
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("你需要先付钱。");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("没有糖果可以分配。");
            }
            else if (state == HAS_QUARTER)
            {
                Console.WriteLine("没有糖果可以分配。");
            }
        }

        public string GetState()
        {
            string states = "未知状态";
            switch (state)
            {
                case SOLD_OUT:
                    states = "糖果售罄";
                    break;
                case NO_QUARTER:
                    states = "没有25分钱";
                    break;
                case HAS_QUARTER:
                    states = "有25分钱";
                    break;
                case SOLD:
                    states = "糖果售出";
                    break;
                default:
                    break;
            }
            return $"{states}(糖果数量{count})";
        }
    }
}
