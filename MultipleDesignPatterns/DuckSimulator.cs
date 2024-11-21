using MultipleDesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns
{
    /// <summary>
    /// 鸭子模拟器
    /// </summary>
    public class DuckSimulator
    {
        // 模拟鸭子行为的方法
        public void Simulate(AbstractDuckFactory duckFactory, AbstractGooseFactory gooseFactory)
        {
            // 创建不同类型的鸭子对象
            Quackable mallardDuck = duckFactory.CreateMallardDuck();
            Quackable redheadDuck = duckFactory.CreateRedheadDuck();
            Quackable duckCall = duckFactory.CreateDuckCall();
            Quackable rubberDuck = duckFactory.CreateRubberDuck();
            Quackable gooseDuck = gooseFactory.CreateGooses();

            //// 打印模拟器信息
            //Console.WriteLine("鸭子模拟器：");

            // 创建一个群体
            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            // 创建一个绿头鸭群体
            Flock flockOfMallards = new Flock();
            Quackable mallardOne = duckFactory.CreateMallardDuck();
            Quackable mallardTwo = duckFactory.CreateMallardDuck();
            Quackable mallardThree = duckFactory.CreateMallardDuck();
            Quackable mallardFour = duckFactory.CreateMallardDuck();
            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            // 将绿头鸭群体加入主群体
            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("鸭子模拟器：整个鸭群模拟");
            Quackologist quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);
            Simulate(flockOfDucks);
            Console.WriteLine();
            Console.WriteLine("鸭子模拟器：野鸭群模拟");
            Simulate(flockOfMallards);

            //// 模拟每种鸭子的叫声
            //Simulate(mallardDuck);
            //Simulate(redheadDuck);
            //Simulate(duckCall);
            //Simulate(rubberDuck);
            //Simulate(gooseDuck);

            Console.WriteLine("鸭子们嘎嘎叫 " + QuackCounter.GetQuacks() + " 次");
        }

        // 模拟单个鸭子的叫声
        public void Simulate(Quackable duck)
        {
            // 调用鸭子的quack方法，多态在这里发挥作用
            duck.Quack();
        }
    }
}
