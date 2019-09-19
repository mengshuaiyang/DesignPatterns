# [原型模式](https://www.oodesign.com/prototype-pattern.html) #
<!-- # [Prototype Pattern](https://www.oodesign.com/prototype-pattern.html) # -->

## 动机 ##
<!-- ## Motivation ## -->

今天的编程是关于成本。在使用计算机资源时，保存是一个大问题，因此程序员正在尽最大努力寻找提高性能的方法。当我们谈论对象创建时，我们可以找到一种更好的方法来获得新对象：克隆。这个是一个特定的设计模式想法：使用克隆创建它。如果创建新对象的成本很高并且创建是资源密集型的，那么我们克隆该对象。
<!-- Today’s programming is all about costs. Saving is a big issue when it comes to using computer resources, so programmers are doing their best to find ways of improving the performance When we talk about object creation we can find a better way to have new objects: cloning. To this idea one particular design pattern is related: rather than creation it uses cloning. If the cost of creating a new object is large and creation is resource intensive, we clone the object. -->

原型设计模式是有问题的。它允许对象在不知道其类或任何创建它们的细节的情况下创建自定义对象。到目前为止这听起来很像工厂方法模式,不同之处在于，对于Factory不包含不止一个对象的原型。

<!-- The Prototype design pattern is the one in question. It allows an object to create customized objects without knowing their class or any details of how to create them. Up to this point it sounds a lot like the Factory Method pattern, the difference being the fact that for the Factory the palette of prototypical objects never contains more than one object. -->

## 意图 ##
<!-- ## Intent ## -->

* 使用原型实例指定要创建的对象类型
<!-- * specifying the kind of objects to create using a prototypical instance -->
* 通过复制此原型来创建新对象
<!-- * creating new objects by copying this prototype -->

## 实现 ##
<!-- ## Implementation ## -->

该模式使用抽象类，我们将在下面看到，实现相当容易只使用三种类就可以。
<!-- The pattern uses abstract classes, as we will see below and only three types of classes making its implementation rather easy. -->

![原型实现——UML类图](imgaes/prototype&#32;implementation&#32;-&#32;uml&#32;class&#32;diagram.gif)
<!-- ![Prototype Implementation - UML Class Diagram](imgaes/prototype&#32;implementation&#32;-&#32;uml&#32;class&#32;diagram.gif) -->

参与原型模式的类:
<!-- The classes participating to the Prototype Pattern are: -->

* **客户端** ——通过要求原型克隆自身来创建新对象。
<!-- * **Client** - creates a new object by asking a prototype to clone itself. -->
* **Prototype**——声明一个用于克隆自身的接口。
<!-- * **Prototype** - declares an interface for cloning itself. -->
* **ConcretePrototype**——实现克隆本身的操作。
<!-- * **ConcretePrototype** - implements the operation for cloning itself. -->

克隆的过程始于一个初始化并实例化类。客户端要求提供该类型的新对象，并将请求发送到Prototype类。根据对象的类型，ConcretePrototype将通过Clone()方法处理克隆，从而创建自身的新实例。
<!-- The process of cloning starts with an initialized and instantiated class. The Client asks for a new object of that type and sends the request to the Prototype class. A ConcretePrototype, depending of the type of object is needed, will handle the cloning through the Clone() method, making a new instance of itself. -->

这是一个原型模式的示例代码:
<!-- Here is a sample code for the Prototype pattern: -->

```java
public interface Prototype {
	public abstract Object clone ( );
}

 

public class ConcretePrototype implements Prototype {
	public Object clone() {
		return super.clone();
	}
}

public class Client {

	public static void main( String arg[] ) 
	{
		ConcretePrototype obj1= new ConcretePrototype ();
		ConcretePrototype obj2 = ConcretePrototype)obj1.clone();
	}

}
```

这个例子相当简单，但是当我们不知道我们实际克隆的是什么时，模式的真正用途就出现了。例如，如果我们需要将新创建的对象存储在哈希表中，我们可以像这样使用它：
<!-- This example is rather trivial, but the real use of the pattern comes when we don’t know what we’re actually cloning. For example if we need the newly created object to be stored in a hashtable we can use it like this: -->

```java
// Violation of Likov's Substitution Principle
class Rectangle
{
	protected int m_width;
	protected int m_height;

	public void setWidth(int width){
		m_width = width;
	}

	public void setHeight(int height){
		m_height = height;
	}


	public int getWidth(){
		return m_width;
	}

	public int getHeight(){
		return m_height;
	}

	public int getArea(){
		return m_width * m_height;
	}	
}

class Square extends Rectangle 
{
	public void setWidth(int width){
		m_width = width;
		m_height = width;
	}

	public void setHeight(int height){
		m_width = height;
		m_height = height;
	}

}

class LspTest
{
	private static Rectangle getNewRectangle()
	{
		// it can be an object returned by some factory ... 
		return new Square();
	}

	public static void main (String args[])
	{
		Rectangle r = LspTest.getNewRectangle();
        
		r.setWidth(5);
		r.setHeight(10);
		// user knows that r it's a rectangle.
		// It assumes that he's able to set the width and height as for the base class

		System.out.println(r.getArea());
		// now he's surprised to see that the area is 100 instead of 50.
	}
}
```

## 适用性和示例 ##
<!-- ## Applicability & Examples ## -->

当系统应独立于其产品的创建，组合和表示方式时，请使用原型模式，并且：
<!-- Use Prototype Pattern when a system should be independent of how its products are created, composed, and represented, and: -->

* 要实例化的类在运行时指定
<!-- * Classes to be instantiated are specified at run-time -->
* 需要避免创建工厂层次结构
<!-- * Avoiding the creation of a factory hierarchy is needed -->
* 复制现有实例比创建新实例更方便。
<!-- * It is more convenient to copy an existing instance than to create a new one. -->

### 示例1 ###
<!-- ### Example 1 ###-->

在使用迷宫和角色遇到的不同视觉对象的游戏的构建阶段需要使用相同对象生成阴霾图的快速方法：墙，门，通道，房间......原型模式在这种情况，因为不是硬编码（使用新操作）实例化的房间，门，通道和墙对象，CreateMaze方法将通过各种原型房间，门，墙和通道对象进行参数化，因此地图的组成可以是通过用不同的对象替换原型对象可以轻松改变。
<!-- In building stages for a game that uses a maze and different visual objects that the character encounters it is needed a quick method of generating the haze map using the same objects: wall, door, passage, room... The Prototype pattern is useful in this case because instead of hard coding (using new operation) the room, door, passage and wall objects that get instantiated, CreateMaze method will be parameterized by various prototypical room, door, wall and passage objects, so the composition of the map can be easily changed by replacing the prototypical objects with different ones. -->

Client是CreateMaze方法，ConcretePrototype类将是为不同对象创建副本的类。
<!-- The Client is the CreateMaze method and the ConcretePrototype classes will be the ones creating copies for different objects. -->

### 示例2: ###
<!-- ### Example 2: ### -->

假设我们正在对数据库中的一组数据进行销售分析。通常，我们会从数据库中复制信息，将其封装到对象中并进行分析。但是，如果需要对同一组数据进行另一次分析，则再次读取数据库并创建新对象并不是最好的选择。如果我们使用原型模式，那么第一次分析中使用的对象将被克隆并用于其他分析。
<!-- Suppose we are doing a sales analysis on a set of data from a database. Normally, we would copy the information from the database, encapsulate it into an object and do the analysis. But if another analysis is needed on the same set of data, reading the database again and creating a new object is not the best idea. If we are using the Prototype pattern then the object used in the first analysis will be cloned and used for the other analysis. -->

客户端是处理封装数据库信息的对象的方法之一。ConcretePrototype类将是从数据库中提取数据后创建的对象将其复制到用于分析的对象的类。
<!-- The Client is here one of the methods that process an object that encapsulates information from the database. The ConcretePrototype classes will be classes that, from the object created after extracting data from the database, will copy it into objects used for analysis. -->

## 具体问题和实现 ##
<!-- ## Specific problems and implementation ## -->

### 使用一个原型管理器 ###
<!-- ### Using a prototype manager ### -->

当应用程序使用大量可以动态创建和销毁的原型时，应保留可用原型的注册表。这个注册表被称为原型管理器，它应该实现管理已注册原型的操作，例如在某个键下注册原型，用给定键搜索原型，从寄存器中删除一个原型等。客户端将使用该接口。原型管理器在运行时处理原型，并在使用Clone()方法之前请求许可。
<!-- When the application uses a lot of prototypes that can be created and destroyed dynamically, a registry of available prototypes should be kept. This registry is called the prototype manager and it should implement operations for managing registered prototypes like registering a prototype under a certain key, searching for a prototype with a given key, removing one from the register, etc. The clients will use the interface of the prototype manager to handle prototypes at run-time and will ask for permission before using the Clone() method. -->

使用原型管理器的原型的实现与使用类注册机制实现的工厂方法之间没有太大区别。也许唯一的区别在于性能。
<!-- There is not much difference between an implementation of a prototype which uses a prototype manager and a factory method implemented using class registration mechanism. Maybe the only difference consists in the performance. -->

### 实现克隆操作 ###
<!-- ### Implementing the Clone operation ### -->

在讨论克隆的深度或浅度时会出现一个小讨论：深度克隆克隆克隆对象中的实例变量，而浅克隆则共享克隆与原始实体之间的实例变量。通常，浅层克隆就足够而且非常简单，但是克隆复杂原型应该使用深度克隆，因此克隆和原始是独立的，深度克隆需要其组件成为复杂对象组件的克隆。
<!-- A small discussion appears when talking about how deep or shallow a clone should be: a deep clone clones the instance variables in the cloning object while a shallow clone shares the instance variables between the clone and the original. Usually, a shallow clone is enough and very simple, but cloning complex prototypes should use deep clones so the clone and the original are independent, a deep clone needing its components to be the clones of the complex object’s components. -->

### 初始化克隆 ###
<!-- ### Initializing clones ### -->

有些情况下，克隆的内部状态应在创建后初始化。发生这种情况是因为这些值无法传递给Clone()方法，该方法使用的接口在使用此类参数时将被销毁。在这种情况下，初始化应该通过使用原型类的设置和重置操作或使用初始化方法来完成，该初始化方法将克隆的内部状态应该设置的值作为参数。
<!-- There are cases when the internal states of a clone should be initialized after it is created. This happens because these values cannot be passed to the Clone() method, that uses an interface which would be destroyed if such parameters were used. In this case the initialization should be done by using setting and resetting operations of the prototype class or by using an initializing method that takes as parameters the values at which the clone’s internal states should be set. -->

## 热点 ##
<!-- ## Hot points ## -->

* 原型管理器 - 通常作为哈希表实现，保持对象克隆。使用它时，原型成为一种工厂方法，它使用克隆而不是实例化。
<!-- * Prototype Manager – implemented usually as a hashtable keeping the object to clone. When use it, prototype become a factory method which uses cloning instead of instantiation. -->
* 深度克隆与浅层克隆 - 当我们克隆包含其他对象的复杂对象时，我们应该注意如何克隆它们。我们也可以克隆包含的对象（深度克隆），或者我们可以为它们提供相同的引用，并在克隆的容器对象之间共享它们。
<!-- * Deep Clones vs. Shallow Clones – when we clone complex objects which contains other objects, we should take care how they are cloned. We can clone contained objects also (deep cloning) or we can the same reference for them, and to share them between cloned container objects. -->
* 初始化内部状态 - 在某些情况下，对象需要在创建后进行初始化。
<!-- * Initializing Internal States – there are certain situations when objects need to be initialized after they are created. -->