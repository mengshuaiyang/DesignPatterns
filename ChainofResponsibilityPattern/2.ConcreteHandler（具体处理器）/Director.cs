using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    // 部门经理
    public class Director : LeaveRequestHandler
    {
        public override void HandleRequest(int days)
        {
            if (days <= 3)
            {
                Console.WriteLine("部门经理批准了请假申请.");
            }
            else if (successor != null)
            {
                successor.HandleRequest(days);
            }
        }
    }
}
