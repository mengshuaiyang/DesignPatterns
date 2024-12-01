## 访问者模式（**Visitor Pattern**）

🌟 **Why：与我何干？**
访问者模式（**Visitor Pattern**）对于你来说很重要，尤其是当你需要对一个对象结构（比如组合结构）中的元素执行操作，而又希望避免修改这些元素的类时。这种模式让你能够添加新的操作，而不需要改变元素类的代码，从而提高了系统的灵活性和扩展性。这对于处理需要动态扩展或者经常变化的业务逻辑非常有用。

🔍 **What：定义、概念解释，可以做什么**
访问者模式是一种**行为型设计模式**，它使你能够自由地添加新的操作到现有的对象结构中，而不需要修改这些元素的类。模式通过分离操作和对象结构，使得你可以在不改变对象结构的情况下，添加新的行为。

🛠️ **How：步骤流程方法，以及解释所需的任何主题内容。包括举例子、打比方等。**
访问者模式通常包含以下几个角色：

1. **Visitor（访问者）**：为每一个 ConcreteElement（具体元素）类声明一个 Visit 操作。
2. **ConcreteVisitor（具体访问者）**：实现每个以 Visit 操作的方法，定义对每个元素类的操作。
3. **Element（元素）**：定义一个 Accept 操作，该操作以一个访问者对象作为参数。
4. **ConcreteElement（具体元素）**：实现 Accept 操作。
5. **ObjectStructure（对象结构）**：能枚举元素，可以提供一个高层访问接口，允许访问者访问元素。

**举例说明**：
假设我们有一个文档编辑系统，其中包含不同类型的文档元素（如段落、图片等），我们希望对这些元素进行不同的操作（如计算字数、高亮显示等）。

- **DocumentElement（文档元素）**：元素接口，定义`Accept`方法。
- **Paragraph**、**Image**：具体元素类，实现`Accept`方法。
- **DocumentVisitor（文档访问者）**：访问者接口，为每种元素定义`Visit`方法。
- **WordCountVisitor**、**HighlightVisitor**：具体访问者类，实现对每种元素的`Visit`方法。
- **Document**：对象结构，包含文档元素的集合，并允许访问者访问它们。

```csharp
// 访问者接口
public interface IDocumentVisitor {
    void Visit(Paragraph paragraph);
    void Visit(Image image);
}

// 具体访问者
public class WordCountVisitor : IDocumentVisitor {
    public void Visit(Paragraph paragraph) {
        // 计算段落字数
    }

    public void Visit(Image image) {
        // 计算图片相关字数
    }
}

public class HighlightVisitor : IDocumentVisitor {
    public void Visit(Paragraph paragraph) {
        // 高亮段落
    }

    public void Visit(Image image) {
        // 高亮图片
    }
}

// 元素接口
public interface IDocumentElement {
    void Accept(IDocumentVisitor visitor);
}

// 具体元素
public class Paragraph : IDocumentElement {
    public void Accept(IDocumentVisitor visitor) {
        visitor.Visit(this);
    }
}

public class Image : IDocumentElement {
    public void Accept(IDocumentVisitor visitor) {
        visitor.Visit(this);
    }
}

// 对象结构
public class Document {
    private List<IDocumentElement> _elements = new List<IDocumentElement>();

    public void Add(IDocumentElement element) {
        _elements.Add(element);
    }

    public void Display(IDocumentVisitor visitor) {
        foreach (var element in _elements) {
            element.Accept(visitor);
        }
    }
}

// 客户端代码
public class Client {
    public static void Main() {
        var doc = new Document();
        doc.Add(new Paragraph());
        doc.Add(new Image());

        var wordCount = new WordCountVisitor();
        var highlight = new HighlightVisitor();

        doc.Display(wordCount);
        doc.Display(highlight);
    }
}
```

🎯 **How Good：可以给听众带来什么好处，什么改变。**
使用访问者模式的好处包括：

- **扩展性**：可以添加新的操作，而不需要修改元素的类。
- **分离关注点**：操作逻辑和对象结构分离，使得代码更清晰。
- **灵活性**：可以对不同的对象结构执行不同的操作。