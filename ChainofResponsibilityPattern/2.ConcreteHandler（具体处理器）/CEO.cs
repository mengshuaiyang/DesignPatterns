using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    // 首席执行官
    public class CEO : LeaveRequestHandler
    {
        public override void HandleRequest(int days)
        {
            if (days > 7)
            {
                Console.WriteLine("首席执行官批准了请假申请.");
            }
        }
    }
}
