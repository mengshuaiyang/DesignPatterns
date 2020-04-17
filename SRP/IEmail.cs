using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    interface IEmail
    {
        void setSender(String sender);
        void setReceiver(String receiver);
        void setContent(IContent content);
    }
}
