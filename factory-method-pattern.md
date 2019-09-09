## 工厂方法模式
[^_^]:## Factory Method Pattern

### 动机
[^_^]:### Motivation

工厂方法也称为虚拟构造函数，它与库工作的思想有关：库使用抽象类来定义和维护对象之间的关系。一种责任是创建这样的对象。库知道何时需要创建对象，但不知道它应该创建什么类型的对象，这是特定于使用库的应用程序。
[^_^]:Also known as Virtual Constructor, the Factory Method is related to the idea on which libraries work: a library uses abstract classes for defining and maintaining relations between objects. One type of responsibility is creating such objects. The library knows when an object needs to be created, but not what kind of object it should create, this being specific to the application using the library.

工厂方法的工作方式相同：:它定义了一个用于创建对象的接口,但是将其类型选择留给了子类，创建在运行时延迟。一个简单的现实生活的例子,工厂方法是酒店。在酒店住宿时，您首先需要办理入住手续。前台工作人员在您支付了您想要的房间后会给您一个房间钥匙，这样他就可以看作是一个**room**工厂。在酒店住宿时，您可能需要拨打电话，所以您打电话给前台，那里的人会将您所需的号码连接到您，成为一个**phone-call工厂**，因为他控制访问调用。
[^_^]:The Factory method works just the same way: it defines an interface for creating an object, but leaves the choice of its type to the subclasses, creation being deferred at run-time. A simple real life example of the Factory Method is the hotel. When staying in a hotel you first have to check in. The person working at the front desk will give you a key to your room after you've paid for the room you want and this way he can be looked at as a �room� factory. While staying at the hotel, you might need to make a phone call, so you call the front desk and the person there will connect you with the number you need, becoming a �phone-call� factory, because he controls the access to calls, too.

### 意图
[^_^]:### Intent
[^_^]:Defines an interface for creating objects, but let subclasses to decide which class to instantiate
[^_^]:Refers to the newly created object through a common interface

* 定义创建对象的接口,让子类决定实例化哪个类
* 通过通用接口引用新创建的对象

### 实现
[^_^]:### Implementation

该模式工作原理基本上如下UML图中所示:
[^_^]:The pattern basically works as shown below, in the UML diagram:

![工厂方法实现——UML类图](imgaes/factory%20method%20implementation%20-%20uml%20class%20diagram.gif)
[^_^]:Factory Method Implementation - UML Class Diagram 

此模式中的参与者类是：
[^_^]:The participants classes in this pattern are:
[^_^]:Product defines the interface for objects the factory method creates.
[^_^]:ConcreteProduct implements the Product interface.
[^_^]:Creator(also refered as Factory because it creates the Product objects) declares the method FactoryMethod, which returns a Product object. May call the generating method for creating Product objects
[^_^]:ConcreteCreator overrides the generating method for creating ConcreteProduct objects

* Product定义工厂方法创建对象的接口。
* ConcreteProduct实现Product接口。
* Creator（也称为Factory因为它创建了Product对象）声明了FactoryMethod方法，它返回一个Product对象。可以调用生成方法来创建Product对象
* ConcreteCreator会覆盖用于创建ConcreteProduct对象的生成方法

所有具体产品都是Product类的子类，因此它们在某种程度上都具有相同的基本实现。Creator类指定产品的所有标准和通用行为，当需要新产品时，它会将客户端提供的创建详细信息发送到ConcreteCreator。记住这个图表，我们现在很容易生成与之相关的代码。以下是经典Factory方法的实现应该如何：
[^_^]:All concrete products are subclasses of the Product class, so all of them have the same basic implementation, at some extent. The Creator class specifies all standard and generic behavior of the products and when a new product is needed, it sends the creation details that are supplied by the client to the ConcreteCreator. Having this diagram in mind, it is easy for us now to produce the code related to it. Here is how the implementation of the classic Factory method should look:

```java
public interface Product { }

public abstract class Creator 
{
	public void anOperation() 
	{
		Product product = factoryMethod();
	}
	
	protected abstract Product factoryMethod();
}

public class ConcreteProduct implements Product { }

public class ConcreteCreator extends Creator 
{
	protected Product factoryMethod() 
	{
		return new ConcreteProduct();
	}
}

public class Client 
{
	public static void main( String arg[] ) 
	{
		Creator creator = new ConcreteCreator();
		creator.anOperation();
	}
}
```

### 适用性和例子
[^_^]:### Applicability & Examples
[^_^]:The need for implementing the Factory Method is very frequent. The cases are the ones below:
[^_^]:when a class can't anticipate the type of the objects it is supposed to create
[^_^]:when a class wants its subclasses to be the ones to specific the type of a newly created object

需要实现工厂方法是非常频繁的。下面的情况:
* 当一个类不能预测它应该创建的对象的类型
* 当一个类想要它的子类是特定于新创建的对象的类型的子类时


#### 示例1 -文档应用程序。
[^_^]:#### Example 1 - Documents Application.

考虑桌面应用程序的框架。此类应用程序旨在处理文档。桌面应用程序框架包含打开，创建和保存文档等操作的定义。基本类是抽象的，名为Application和Document，它们的客户端必须从它们创建子类才能定义自己的应用程序。例如，为了生成绘图应用程序，他们需要定义DrawingApplication和DrawingDocument类。Application类的任务是管理文档，根据客户端的请求采取操作（例如，当用户从菜单中选择打开或保存命令时）。
[^_^]:Take into consideration a framework for desktop applications. Such applications are meant to work with documents. A framework for desktop applications contains definitions for operations such as opening, creating and saving a document. The basic classes are abstract ones, named Application and Document, their clients having to create subclasses from them in order to define their own applications. For generating a drawing application, for example, they need to define the DrawingApplication and DrawingDocument classes. The Application class has the task of managing the documents, taking action at the request of the client (for example, when the user selects the open or save command form the menu).

因为需要实例化的Document类是特定于应用程序的，所以Application类不会事先知道它，因此它不知道要实例化什么，但它确实知道何时实例化它。框架需要实例化某个类，但它只知道无法实例化的抽象类。
[^_^]:Because the Document class that needs to be instantiated is specific to the application, the Application class does not know it in advance, so it doesn't know what to instantiate, but it does know when to instantiate it. The framework needs to instantiate a certain class, but it only knows abstract classes that can't be instantiated.

工厂方法设计模式通过将与需要实例化的类相关的所有信息放入对象并在框架外部使用它来解决问题，如下所示
[^_^]:The Factory Method design pattern solves the problem by putting all the information related to the class that needs to be instantiated into an object and using them outside the framework, as you can see below

![工厂方法的例子——UML类图](imgaes/factory%20method%20example%20-%20uml%20class%20diagram.gif)
[^_^]:Factory Method Example - UML Class Diagram

在Application类中，CreateDocument方法要么具有默认实现，要么根本没有任何实现，此操作在MyApplication子类中重新定义，以便创建MyDocument对象并返回对它的引用。
[^_^]:In the Application class the CreateDocument method either has a default implementation or it doesn't have any implementation at all, this operation being redefined in the MyApplication subclass so that it creates a MyDocument object and returns a reference to it.

```java
public Document CreateDocument(String type){
	if (type.isEqual("html"))
		return new HtmlDocument();
	if (type.isEqual("proprietary"))
		return new MyDocument();
	if (type.isEqual("pdf"))
		return new PdfDocument ();
}
```

假设Application类有一个名为docs的成员，表示应用程序正在处理的文档列表，那么NewDocument方法应如下所示：
[^_^]:Assuming that the Application class has a member called docs that represents a list of documents being handled by the application, then the NewDocument method should look like this:

```java
public void NewDocument(String type){
	Document doc=CreateDocument(type);
	Docs.add(doc);
	Doc.Open();
}
```

此方法将由MyApplication类继承，因此，通过CreateDocument方法，它将实际实例化MyDocument对象。我们将CreateDocument方法称为Factory方法，因为它负责“制作”一个对象。通过这个方法，在Application的子类中重新定义，我们实际上可以塑造Application类在不知道其类型的情况下创建对象的情况。从这个角度来看，工厂方法是为我们提供实现依赖倒置原则(DIP)的方式。
[^_^]:This method will be inherited by the MyApplication class and, so, through the CreateDocument method, it will actually instantiate MyDocument objects. We will call the CreateDocument method a Factory Method because it is responsible with 'making' an object. Through this method, redefined in Application's subclasses, we can actually shape the situation in which the Application class creates objects without knowing their type. From this point of view the factory method is pattern which provides us a way to achieve the DIP principle.

### 具体问题和实现
[^_^]:### Specific problems and implementation

实现工厂方法设计模式时可能会出现一些问题:
[^_^]:When implementing the Factory Method design pattern some issues may appear:


#### 创造者的定义类
[^_^]:#### Definition of Creator class

如果我们将模式应用于已经编写的代码，那么我们已经定义了Creator类的方式可能存在问题。有两种情况：
[^_^]:If we apply the pattern to an already written code there may be problems with the way we have the Creator class already defined. There are two cases:
[^_^]:Creator class is abstract and generating method does not have any implementation. In this case the ConcreteCreator classes must define their own generation method and this situation usually appears in the cases where the Creator class can't foresee what ConcreteProduct it will instantiate.
[^_^]:Creator class is a concrete class, the generating method having a default implementation. If this happens, the ConcreteCreator classes will use the generating method for flexibility rather than for generation. The programmer will always be able to modify the class of the objects that the Creator class implicitly creates, redefining the generation method.

* Creator类是抽象的，生成方法没有任何实现。在这种情况下，ConcreteCreator类必须定义自己的生成方法，这种情况通常出现在Creator类无法预见它将实例化的ConcreteProduct的情况下。
* Creator类是一个具体的类，生成方法具有默认实现。如果发生这种情况，ConcreteCreator类将使用生成方法来实现灵活性而不是生成。程序员将始终能够修改Creator类隐式创建的对象的类，重新定义生成方法。


工厂方法只是工厂设计模式的一个特例。与此同时，它是最着名的工厂模式，也许是因为它是在GoF上发布的。在现代编程语言中，更多地使用具有注册的工厂。
[^_^]:Factory method is just a particular case of the factory design pattern. In the same time it is the most known factory pattern, maybe because it was published in the GoF. In modern programming languages the factory with registration is more used.

### 弊端和好处
[^_^]:### Drawbacks and Benefits

这是工厂方法模式的优缺点:
[^_^]:Here are the benefits and drawbacks of factory method pattern:
[^_^]: The main reason for which the factory pattern is used is that it introduces a separation between the application and a family of classes (it introduces weak coupling instead of tight coupling hiding concrete classes from the application). It provides a simple way of extending the family of products with minor changes in application code.
[^_^]: It provides customization hooks. When the objects are created directly inside the class it's hard to replace them by objects which extend their functionality. If a factory is used instead to create a family of objects the customized objects can easily replace the original objects, configuring the factory to create them.
[^_^]: The factory has to be used for a family of objects. If the classes doesn't extend common base class or interface they can not be used in a factory design template.

* \+ 使用工厂模式的主要原因是它引入了应用程序和类系列之间的分离（它引入了弱耦合而不是紧密耦合隐藏了应用程序中的具体类）。它提供了一种扩展产品系列的简单方法，只需对应用程序代码进行微小更改即可。
* \+ 它提供自定义挂钩。当直接在类中创建对象时，很难用扩展其功能的对象替换它们。如果使用工厂来创建一系列对象，则自定义对象可以轻松替换原始对象，配置工厂以创建它们。
* \- 工厂必须用于一系列物体。如果类没有扩展公共基类或接口，则它们不能在工厂设计模板中使用。


### 热点:
[^_^]:### Hot Points:

工厂方法是最常用和最稳健的设计模式之一。实现工厂方法时，只需要考虑几点。
[^_^]:The factory method is one of the most used and one of the more robust design patterns. There are only few points which have to be considered when you implement a factory method.

当你设计一个应用程序时，只要想想你是否真的需要一个工厂来创建对象。使用它可能会给您的应用带来不必要的复杂性。无论如何，如果你有许多相同基类型的对象，并且你主要将它们作为抽象对象进行操作，那么你需要一个工厂。如果你的的代码应该有很多代码如下，应该重新考虑它。
[^_^]:When you design an application just think if you really need it a factory to create objects. Maybe using it will bring unnecessary complexity in your application. Anyway if you have many object of the same base type and you manipulate them mostly as abstract objects, then you need a factory. If you're code should have a lot of code like the following, reconsider it.

```java
if (genericProduct typeof ConcreteProduct)
	((ConcreteProduct)genericProduct).doSomeConcreteOperation();
```