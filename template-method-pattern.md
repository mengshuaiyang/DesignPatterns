## 模板方法模式（**Template Method Pattern**）

🌟 **Why：与我何干？**

模板方法模式（**Template Method Pattern**）是一种行为型设计模式，它在父类中定义了一个算法的框架，允许子类在不改变算法结构的情况下重写算法的某些特定步骤。这对于我们来说很重要，因为它让我们能够保证算法的一致性，同时提供灵活性，允许子类根据需要定制某些操作，这样既保持了代码的复用性，又增加了灵活性。

🔍 **What：定义、概念解释，可以做什么**

模板方法模式是一种**行为型设计模式**，它定义了一个操作中的算法框架，将一些步骤延迟到子类中实现。模板方法使得子类可以在不改变算法结构的情况下，重新定义算法的某些步骤。这种模式常用于实现算法的不变部分，同时允许子类自定义某些特定步骤。

🛠️ **How：步骤流程方法，以及解释所需的任何主题内容。包括举例子、打比方等。**

模板方法模式通常包含以下几个角色：

1. **AbstractClass（抽象类）**：定义了模板方法和算法框架，以及一些基本操作的默认实现。
2. **ConcreteClass（具体类）**：实现或重写抽象类中的操作，填充算法框架的某些步骤。

**举例说明**：

假设我们有一个咖啡店，提供不同的咖啡制作方法，但基本步骤（如研磨咖啡豆、烧水、冲泡）是相同的：

- **Coffee（咖啡）**：抽象类，定义了一个模板方法`BrewCoffee`，它包含了制作咖啡的基本步骤。
- **Espresso（浓缩咖啡）**、**Latte（拿铁）**：具体类，它们继承自`Coffee`类，并重写某些步骤以提供特定的咖啡制作方式。

```csharp
// 抽象类
public abstract class Coffee {
    // 模板方法
    public final void BrewCoffee() {
        GroundCoffee();
        Brew();
        PourInCup();
        AddCondiments();
    }

    protected abstract void GroundCoffee();
    protected abstract void Brew();
    protected abstract void PourInCup();
    protected abstract void AddCondiments();
}

// 具体类
public class Espresso : Coffee {
    protected override void GroundCoffee() {
        Console.WriteLine("Grinding Italian Roast Coffee beans fine for Espresso");
    }

    protected override void Brew() {
        Console.WriteLine("Brewing in an Espresso Machine");
    }

    protected override void PourInCup() {
        Console.WriteLine("Pouring into a small cup");
    }

    protected override void AddCondiments() {
        Console.WriteLine("Adding sugar and milk froth");
    }
}

public class Latte : Coffee {
    protected override void GroundCoffee() {
        Console.WriteLine("Grinding French Roast Coffee beans coarse for Latte");
    }

    protected override void Brew() {
        Console.WriteLine("Brewing in a French Press");
    }

    protected override void PourInCup() {
        Console.WriteLine("Pouring into a large cup");
    }

    protected override void AddCondiments() {
        Console.WriteLine("Adding milk and a little bit of cinnamon");
    }
}
```

🎯 **How Good：可以给听众带来什么好处，什么改变。**

使用模板方法模式的好处包括：

- **代码复用**：模板方法提供了算法的框架，允许子类复用代码。
- **扩展性**：子类可以重写某些步骤，而不需要改变算法的整体结构。
- **降低耦合度**：子类不需要知道算法的详细实现，只需要关注自己的特定步骤。