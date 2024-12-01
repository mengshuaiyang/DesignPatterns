using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeaveRequestHandler ceo = new CEO();
            LeaveRequestHandler hrManager = new HRManager();
            LeaveRequestHandler director = new Director();

            director.SetSuccessor(hrManager);
            hrManager.SetSuccessor(ceo);

            director.HandleRequest(1); // 部门经理处理
            director.HandleRequest(5); // 人力资源经理处理
            director.HandleRequest(10); // 首席执行官处理

            Console.ReadKey();
        }
    }
}
