**命令模式**将“请求”封装成对象，以便使用不同的请求队列或者日志来参数化其他对象。命令模式也支持可撤销
的操作。

🌟 **Why：与我何干？**

命令模式（**Command Pattern**）是一种行为设计模式，它将请求封装为一个对象，从而允许用户使用不同的请求、队列或日志请求来参数化其他对象。这对于我们来说很重要，因为它可以帮助我们实现操作的撤销和重做，以及解耦发送者和接收者，使得代码更加灵活和易于扩展。

🔍 **What：定义、概念解释，可以做什么**

命令模式是一种**行为型设计模式**，它将一个请求或简单操作封装为一个对象。这个模式涉及四个角色：命令（Command）、具体命令（ConcreteCommand）、客户端（Client）和接收者（Receiver）。命令对象包含执行操作的方法，接收者对象包含实际执行操作的逻辑，客户端负责创建具体的命令对象并设置其接收者。

🛠️ **How：步骤流程方法，以及解释所需的任何主题内容。包括举例子、打比方等。**

命令模式通常包含以下几个角色：

1. **Command（命令）**：定义命令的接口，声明执行操作的方法。
2. **ConcreteCommand（具体命令）**：实现命令接口，定义接收者和调用接收者的方法。
3. **Client（客户端）**：创建具体的命令对象，并设置其接收者。
4. **Receiver（接收者）**：知道如何实施与执行一个请求相关的操作。

**举例说明**：

假设我们有一个简单的遥控器，可以控制不同的家用电器：

- **Command（命令）**：一个接口，定义了`Execute`方法。
- **ConcreteCommand（具体命令）**：具体命令类，如`LightOnCommand`和`TVOnCommand`，它们实现了`Command`接口。
- **RemoteControl（遥控器）**：客户端，它创建具体的命令对象，并设置其接收者。
- **Light（灯）**、**TV（电视）**：接收者类，它们包含实际的操作逻辑。

```csharp
// 命令接口
public interface ICommand {
    void Execute();
    void Undo();
}

// 具体命令
public class LightOnCommand : ICommand {
    private readonly Light _light;

    public LightOnCommand(Light light) {
        _light = light;
    }

    public void Execute() {
        _light.On();
    }

    public void Undo() {
        _light.Off();
    }
}

// 接收者
public class Light {
    public void On() {
        Console.WriteLine("Light is on");
    }

    public void Off() {
        Console.WriteLine("Light is off");
    }
}

// 客户端
public class RemoteControl {
    private ICommand _command;

    public void SetCommand(ICommand command) {
        _command = command;
    }

    public void PressButton() {
        _command.Execute();
    }
}
```

🎯 **How Good：可以给听众带来什么好处，什么改变。**
使用命令模式的好处包括：

- **解耦发送者和接收者**：发送者不需要知道接收者的具体类，只需要知道命令接口。
- **扩展性**：可以轻松添加新的命令，而不需要修改现有的代码。
- **支持撤销和重做操作**：可以很容易地实现命令的撤销和重做功能。