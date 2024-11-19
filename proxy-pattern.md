🌟 **Why：与我何干？**

代理模式（**Proxy Pattern**）是一种结构型设计模式，它为其他对象提供一个代理或占位符以控制对这个对象的访问。这对于我们来说很重要，因为它可以帮助我们管理对资源密集型对象的访问，延迟对象的创建，或者在访问对象时添加额外的安全控制和日志记录等功能。

🔍 **What：定义、概念解释，可以做什么**

代理模式为一个对象提供一个代理对象，并由代理对象控制对原对象的访问。这种模式使得客户端代码可以透明地与代理对象进行交互，而不需要直接与实际对象交互。代理模式可以用于延迟对象的初始化、访问控制、日志记录、缓存等场景。

🛠️ **How：步骤流程方法，以及解释所需的任何主题内容。包括举例子、打比方等。**

代理模式通常包含以下几个角色：

1. **Subject（主题）**：定义了真实对象和代理对象共有的接口，这样代理可以用来代替真实对象。
2. **Proxy（代理）**：包含对真实对象的引用，实现了与真实对象相同的接口，并在访问真实对象之前或之后添加额外的处理。
3. **RealSubject（真实主题）**：定义了代理所代表的真实对象，实现了主题接口。

**举例说明**：

假设我们有一个图像加载的场景，我们希望延迟图像的加载，直到它真正被需要时：

- **Image（图像）**：主题接口，定义了`display()`方法。
- **RealImage（真实图像）**：真实主题类，实现了`Image`接口，代表实际的图像对象。
- **ProxyImage（代理图像）**：代理类，也实现了`Image`接口，它包含对`RealImage`的引用，并在调用`display()`方法时延迟加载图像。

```csharp
// 主题接口
public interface Image {
    void display();
}

// 真实主题
public class RealImage : Image {
    private string _filename;

    public RealImage(string filename) {
        _filename = filename;
        LoadFromDisk(); // 模拟从磁盘加载
    }

    public void display() {
        Console.WriteLine("Displaying " + _filename);
    }

    private void LoadFromDisk() {
        Console.WriteLine("Loading " + _filename);
    }
}

// 代理
public class ProxyImage : Image {
    private RealImage _realImage;
    private string _filename;

    public ProxyImage(string filename) {
        _filename = filename;
    }

    public void display() {
        if (_realImage == null) {
            	realImage = new RealImage(_filename);
        }
        _realImage.display();
    }
}
```

🎯 **How Good：可以给听众带来什么好处，什么改变。**

使用代理模式的好处包括：

- **延迟初始化**：可以在需要时才创建资源密集型的对象，节省资源。
- **访问控制**：可以在访问对象时添加安全检查，控制对对象的访问。
- **日志记录**：可以在访问对象前后添加日志记录，方便调试和监控。
