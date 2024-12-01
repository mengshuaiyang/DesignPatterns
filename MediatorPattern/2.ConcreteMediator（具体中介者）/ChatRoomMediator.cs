using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 具体中介者
    /// 实现中介者接口，定义对象如何相互交互的具体逻辑。
    /// </summary>
    public class ChatRoomMediator : IChatMediator
    {
        private List<User> _users = new List<User>();

        public void RegisterUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var recipient in _users)
            {
                if (recipient != user)
                {
                    recipient.Receive(message);
                }
            }
        }
    }

}
