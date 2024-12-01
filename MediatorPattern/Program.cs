using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ChatRoomMediator();
            var user1 = new User("用户1", mediator);
            var user2 = new User("用户2", mediator);
            var user3 = new User("用户3", mediator);

            mediator.RegisterUser(user1);
            mediator.RegisterUser(user2);
            mediator.RegisterUser(user3);

            user1.Send("你好, 用户2!");

            Console.ReadKey();
        }
    }
}
