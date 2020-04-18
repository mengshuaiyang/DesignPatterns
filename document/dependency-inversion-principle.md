# [依赖倒置原则](https://www.oodesign.com/dependency-inversion-principle.html) #
<!-- # Dependency Inversion Principle # -->

## 动机 ##
<!-- ## Motivation ## -->

在设计软件应用程序时，我们可以考虑实现基本和主要操作的低级类（磁盘访问，网络协议等），以及封装复杂逻辑的高级类（业务流等）。最后一个依赖于低级别的类。实现此类结构的自然方法是编写底层类，一旦让他们编写复杂的高层类。由于高级类是根据其他类定义的，因此这似乎是合乎逻辑的方法。但这不是一个灵活的设计。如果我们需要替换低级别的类，会发生什么？
<!-- When we design software applications we can consider the low level classes the classes which implement basic and primary operations(disk access, network protocols,...) and high level classes the classes which encapsulate complex logic(business flows, ...). The last ones rely on the low level classes. A natural way of implementing such structures would be to write low level classes and once we have them to write the complex high level classes. Since high level classes are defined in terms of others this seems the logical way to do it. But this is not a flexible design. What happens if we need to replace a low level class? -->

让我们以复制模块的经典示例为例，该模块从键盘读取字符并将其写入打印机设备。包含逻辑的高级类是Copy类。低级类是KeyboardReader和PrinterWriter。
<!-- Let's take the classical example of a copy module which reads characters from the keyboard and writes them to the printer device. The high level class containing the logic is the Copy class. The low level classes are KeyboardReader and PrinterWriter. -->

高级类别直接使用并且严重依赖于低级类别是一个不好的设计。在这种情况下，如果我们要更改设计以将输出定向到新的FileWriter类，则必须在Copy类中进行更改。（让我们假设它是一个非常复杂的类，具有很多逻辑并且真的很难测试）。
<!-- In a bad design the high level class uses directly and depends heavily on the low level classes. In such a case if we want to change the design to direct the output to a new FileWriter class we have to make changes in the Copy class. (Let's assume that it is a very complex class, with a lot of logic and really hard to test). -->

为了避免此类问题，我们可以在高级类和低级类之间引入一个抽象层。由于高级模块包含复杂的逻辑，因此它们不应依赖于低级模块，因此不应基于低级模块创建新的抽象层。低层模块将基于抽象层创建。
<!-- In order to avoid such problems we can introduce an abstraction layer between high level classes and low level classes. Since the high level modules contain the complex logic they should not depend on the low level modules so the new abstraction layer should not be created based on low level modules. Low level modules are to be created based on the abstraction layer. -->

根据此原理，设计类结构的方法是从高级模块开始到低级模块：
高级类->抽象层->低级类
<!-- According to this principle the way of designing a class structure is to start from high level modules to the low level modules:
High Level Classes -- Abstraction Layer -- Low Level Classes -->

## 意图 ##
<!-- ## Intent ## -->

> * 高级模块不应依赖于低级模块。两者都应依赖抽象。
> * 抽象不应依赖细节。细节应取决于抽象。

<!-- 
> * High-level modules should not depend on low-level modules. Both should depend on abstractions.
> * Abstractions should not depend on details. Details should depend on abstractions. -->

## 例子 ##
<!-- ## Example ## -->

以下是违反依赖倒置原则的示例。我们有一个Manager类，它是一个高级类，而底层类是Worker。我们需要在应用程序中添加一个新模块，以对由聘用新的专业工人所决定的公司结构的变化进行建模。为此，我们创建了一个新的类SuperWorker。
<!-- Below is an example which violates the Dependency Inversion Principle. We have the manager class which is a high level class, and the low level class called Worker. We need to add a new module to our application to model the changes in the company structure determined by the employment of new specialized workers. We created a new class SuperWorker for this. -->

假设Manager类非常复杂，包含非常复杂的逻辑。现在，我们必须对其进行更改以引入新的SuperWorker。让我们看看缺点：
<!-- Let's assume the Manager class is quite complex, containing very complex logic. And now we have to change it in order to introduce the new SuperWorker. Let's see the disadvantages: -->

> * 我们必须更改Manager类（请记住这是一个复杂的类，这需要花费时间和精力进行更改）。
> * Manager类中的某些当前功能可能会受到影响。
> * 重做单元测试。

<!-- 
> * we have to change the Manager class (remember it is a complex one and this will involve time and effort to make the changes).
> * some of the current functionality from the manager class might be affected.
> * the unit testing should be redone. -->

所有这些问题可能需要花费很多时间才能解决，并且可能在旧功能中引发新的错误。如果应用程序是按照依赖倒置原则设计的，情况将有所不同。这意味着我们将设计Manager类，IWorker接口和实现IWorker接口的Worker类。当我们需要添加SuperWorker类时，我们要做的就是为其实现IWorker接口。现有类中没有其他更改。
<!-- All those problems could take a lot of time to be solved and they might induce new errors in the old functionlity. The situation would be different if the application had been designed following the Dependency Inversion Principle. It means we design the manager class, an IWorker interface and the Worker class implementing the IWorker interface. When we need to add the SuperWorker class all we have to do is implement the IWorker interface for it. No additional changes in the existing classes. -->

```java
// 依赖反转原则-错误的示例
// Dependency Inversion Principle - Bad example

class Worker {

	public void work() {

		// ....working

	}

}



class Manager {

	Worker worker;



	public void setWorker(Worker w) {
		worker = w;
	}

	public void manage() {
		worker.work();
	}
}

class SuperWorker {
	public void work() {
		//.... working much more
	}
}
```
以下是支持依赖倒置原则的代码。在这个新设计中，通过IWorker接口添加了新的抽象层。现在解决了上述代码中的问题（考虑到高级逻辑没有变化）：
<!-- Below is the code which supports the Dependency Inversion Principle. In this new design a new abstraction layer is added through the IWorker Interface. Now the problems from the above code are solved(considering there is no change in the high level logic): -->

> * 添加SuperWorkers时，Manager类不需要更改。
> * 由于我们没有更改，因此将影响Manager类中旧功能的风险降至最低。
> * 无需为Manager类重做单元测试。
<!-- 
> * Manager class doesn't require changes when adding SuperWorkers.
> * Minimized risk to affect old functionality present in Manager class since we don't change it.
> * No need to redo the unit testing for Manager class. -->
  
```java
// //依赖反转原则-很好的示例
// Dependency Inversion Principle - Good example
interface IWorker {
	public void work();
}

class Worker implements IWorker{
	public void work() {
		// ....working
	}
}

class SuperWorker  implements IWorker{
	public void work() {
		//.... working much more
	}
}

class Manager {
	IWorker worker;

	public void setWorker(IWorker w) {
		worker = w;
	}

	public void manage() {
		worker.work();
	}
}
```

## 结论 ##
<!-- ## Conclusion ## -->

当应用此原则时，这意味着高级类不能直接与低级类一起使用，而是将接口用作抽象层。在这种情况下，无法使用new运算符实例化高级类中的新低级对象（如果需要）。相反，可以使用某些创建型设计模式，例如工厂方法，抽象工厂，原型。
<!-- When this principle is applied it means the high level classes are not working directly with low level classes, they are using interfaces as an abstract layer. In this case instantiation of new low level objects inside the high level classes(if necessary) can not be done using the operator new. Instead, some of the Creational design patterns can be used, such as Factory Method, Abstract Factory, Prototype. -->

模板设计模式是应用DIP原理的示例。
<!-- The Template Design Pattern is an example where the DIP principle is applied. -->

当然，使用此原则意味着要付出更多的努力，这将导致要维护的类和接口更多，仅用几句话就可以实现更复杂的代码，但是更加灵活。此原则不应盲目地应用于每个类或每个模块。如果我们拥有将来更可能保持不变的类功能，则无需应用此原理。
<!-- Of course, using this principle implies an increased effort, will result in more classes and interfaces to maintain, in a few words in more complex code, but more flexible. This principle should not be applied blindly for every class or every module. If we have a class functionality that is more likely to remain unchanged in the future there is not need to apply this principle. -->
