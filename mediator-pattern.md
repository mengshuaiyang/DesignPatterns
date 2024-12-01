## 中介者模式（**Mediator Pattern**）

🌟 **Why：与我何干？**
中介者模式（**Mediator Pattern**）对于你来说很重要，尤其是当你需要降低多个对象或类之间的通信复杂性时。这种模式可以帮助你减少它们之间的耦合度，使得各对象不需要显式地相互引用。这在你处理一个系统中对象间的复杂交互时非常有用，它可以让你的对象更加专注于自己的职责，而不是如何与其他对象通信。

🔍 **What：定义、概念解释，可以做什么**
中介者模式是一种**行为型设计模式**，它定义了一个中介对象来封装一系列对象之间的交互。中介者使对象之间的耦合松散，并且可以独立地改变它们之间的交互和逻辑。这种模式常用于模拟一个集中控制的系统，如命令调度中心、网络请求的分发处理等。

🛠️ **How：步骤流程方法，以及解释所需的任何主题内容。包括举例子、打比方等。**
中介者模式通常包含以下几个角色：

1. **Mediator（中介者）**：定义一个接口，该接口用于同事对象之间的通信。
2. **ConcreteMediator（具体中介者）**：实现中介者接口，定义对象如何相互交互的具体逻辑。
3. **Colleague（同事）**：每个同事对象只知道中介者，有任何需要交互的事情都委托给中介者处理，同事类之间不直接通信。

**举例说明**：
假设我们有一个聊天室系统，用户（同事）之间的消息传递需要通过一个聊天服务（中介者）来转发。

- **ChatMediator（聊天中介者）**：中介者接口，定义用户之间的通信协议。
- **User（用户）**：同事类，每个用户只知道如何通过聊天服务发送和接收消息。
- **ChatRoomMediator（聊天室中介者）**：具体中介者，实现聊天中介者接口，管理用户之间的消息传递。

```csharp
// 中介者接口
public interface IChatMediator {
    void SendMessage(string message, User user);
    void RegisterUser(User user);
}

// 用户
public class User {
    private string _name;
    private IChatMediator _mediator;

    public User(string name, IChatMediator mediator) {
        _name = name;
        _mediator = mediator;
    }

    public void Send(string message) {
        _mediator.SendMessage(message, this);
    }

    public void Receive(string message) {
        Console.WriteLine($"{_name} received: {message}");
    }
}

// 具体中介者
public class ChatRoomMediator : IChatMediator {
    private List<User> _users = new List<User>();

    public void RegisterUser(User user) {
        _users.Add(user);
    }

    public void SendMessage(string message, User user) {
        foreach (var recipient in _users) {
            if (recipient != user) {
                recipient.Receive(message);
            }
        }
    }
}

// 客户端代码
public class Client {
    public static void Main() {
        var mediator = new ChatRoomMediator();
        var user1 = new User("User1", mediator);
        var user2 = new User("User2", mediator);

        mediator.RegisterUser(user1);
        mediator.RegisterUser(user2);

        user1.Send("Hello User2!");
    }
}
```

🎯 **How Good：可以给听众带来什么好处，什么改变。**
使用中介者模式的好处包括：

- **降低耦合度**：对象之间的通信通过中介者进行，减少了对象之间的依赖。
- **提高可维护性**：对象间的交互逻辑集中在中介者中，使得交互逻辑更容易管理和维护。
- **易于扩展**：添加新的同事对象时，不需要修改其他对象的代码，只需要确保它们知道中介者即可。
