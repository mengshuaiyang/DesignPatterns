using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 中介者接口
    /// 定义一个接口，该接口用于同事对象之间的通信。
    /// </summary>
    public interface IChatMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }

}
