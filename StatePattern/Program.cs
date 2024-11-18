using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 普通实现

            //// 创建一个新的GumballMachine对象，初始有5颗糖果
            //GumballMachine gumballMachine = new GumballMachine(5);

            //// 打印出机器的初始状态
            //Console.WriteLine(gumballMachine.GetState());

            //// 模拟用户投入25分钱并转动曲柄
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //// 再次打印出机器的状态
            //Console.WriteLine(gumballMachine.GetState());

            //// 再次模拟用户投入25分钱，然后退回25分钱并转动曲柄
            //gumballMachine.InsertQuarter();
            //gumballMachine.EjectQuarter();
            //gumballMachine.TurnCrank();
            //// 打印出机器的状态
            //Console.WriteLine(gumballMachine.GetState());

            //// 模拟用户连续三次投入25分钱并转动曲柄，然后退回25分钱
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.EjectQuarter();
            //// 打印出机器的状态
            //Console.WriteLine(gumballMachine.GetState());

            //// 模拟用户连续三次投入25分钱并转动曲柄，进行压力测试
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //// 最后一次打印出机器的状态
            //Console.WriteLine(gumballMachine.GetState());

            #endregion

            #region 使用状态模式优化代码

            // 创建一个新的GumballMachine对象，初始有5颗糖果
            GumballMachineNew gumballMachine = new GumballMachineNew(10);

            // 打印出机器的初始状态
            Console.WriteLine(gumballMachine.GetState());

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("***********************");
                // 模拟用户投入25分钱并转动曲柄
                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();
                // 再次打印出机器的状态
                Console.WriteLine(gumballMachine.GetState());
                Console.WriteLine();
                Console.WriteLine();
            }
           

            //// 再次模拟用户投入25分钱并转动曲柄
            //gumballMachine.InsertQuarter();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.TurnCrank();
            //// 再次打印出机器的状态
            //Console.WriteLine(gumballMachine.GetState());

            #endregion


            Console.ReadKey();
        }
    }
}
