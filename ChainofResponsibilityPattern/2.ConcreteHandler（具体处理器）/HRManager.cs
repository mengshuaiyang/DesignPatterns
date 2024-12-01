using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    // 人力资源经理
    public class HRManager : LeaveRequestHandler
    {
        public override void HandleRequest(int days)
        {
            if (days > 3 && days <= 7)
            {
                Console.WriteLine("人力资源经理批准了请假申请.");
            }
            else if (successor != null)
            {
                successor.HandleRequest(days);
            }
        }
    }
}
