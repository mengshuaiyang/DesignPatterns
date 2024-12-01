using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 用户
    /// 每个同事对象只知道中介者，有任何需要交互的事情都委托给中介者处理，同事类之间不直接通信。
    /// </summary>
    public class User
    {
        private string _name;
        private IChatMediator _mediator;

        public User(string name, IChatMediator mediator)
        {
            _name = name;
            _mediator = mediator;
        }

        public void Send(string message)
        {
            _mediator.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{_name} 已收到: {message}");
        }
    }
}
