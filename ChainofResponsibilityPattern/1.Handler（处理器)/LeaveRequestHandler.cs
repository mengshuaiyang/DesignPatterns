using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    // 处理器接口
    public abstract class LeaveRequestHandler
    {
        protected LeaveRequestHandler successor;

        public void SetSuccessor(LeaveRequestHandler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int days);
    }
}
