## [工厂模式](https://www.oodesign.com/factory-pattern.html)
[^_^]:## Factory Pattern

### 动机
[^_^]:### Motivation

工厂设计模式可能是Java和C＃等现代编程语言中最常用的设计模式。它有不同的变体和实现。如果您正在搜索它，很可能会找到有关GoF模式的参考：工厂方法模式和抽象工厂模式。
[^_^]:The Factory Design Pattern is probably the most used design pattern in modern programming languages like Java and C#. It comes in different variants and implementations. If you are searching for it, most likely, you'll find references about the GoF patterns: Factory Method and Abstract Factory.

 
在本文中,我们将描述一个现在工厂模式常用的风格。您还可以检查非常相似的原始Factory Method模式。
[^_^]:In this article we'll describe a flavor of factory pattern commonly used nowdays. You can also check the original Factory Method pattern which is very similar.


### 意图
[^_^]:### Intent
[^_^]:creates objects without exposing the instantiation logic to the client.
[^_^]:refers to the newly created object through a common interface

* 创建对象而不将实例化逻辑暴露给客户端。
* 通过公共接口引用新创建的对象

### 实现
[^_^]:### Implementation

![工厂实现——UML类图](imgaes/factory%20implementation.gif)
[^_^]:Factory Implementation - UML Class Diagram

实现非常简单
[^_^]:The implementation is really simple
[^_^]:The client needs a product, but instead of creating it directly using the new operator, it asks the factory object for a new product, providing the information about the type of object it needs.
[^_^]:The factory instantiates a new concrete product and then returns to the client the newly created product(casted to abstract product class).
[^_^]:The client uses the products as abstract products without being aware about their concrete implementation.

* 客户端需要一个产品，但不是直接使用new运算符创建它，而是向工厂对象请求新产品，提供有关所需对象类型的信息。
* 工厂实例化一个新的具体产品，然后将新创建的产品返回给客户端（转换为抽象产品类）。
* 客户将产品用作抽象产品，而不了解其具体如何实现。

### 适用性和例子
[^_^]:### Applicability & Examples

工厂模式可能是最常用的模式之一。
[^_^]:Probably the factory pattern is one of the most used patterns.

例如，图形应用程序使用形状。在我们的实现中，绘图框架是客户端，形状是产品。所有形状都来自抽象形状类（或接口）。Shape类定义必须由具体形状实现的绘制和移动操作。假设从菜单中选择一个命令来创建一个新的圆。框架接收形状类型作为字符串参数，它要求工厂创建发送从菜单接收的参数的新形状。工厂创建一个新的圆圈并将其返回到框架，铸造成抽象的形状。然后框架将对象用作抽象类，而不需要知道具体的对象类型。
[^_^]:For example a graphical application works with shapes. In our implementation the drawing framework is the client and the shapes are the products. All the shapes are derived from an abstract shape class (or interface). The Shape class defines the draw and move operations which must be implemented by the concrete shapes. Let's assume a command is selected from the menu to create a new Circle. The framework receives the shape type as a string parameter, it asks the factory to create a new shape sending the parameter received from menu. The factory creates a new circle and returns it to the framework, casted to an abstract shape. Then the framework uses the object as casted to the abstract class without being aware of the concrete object type.


优势显而易见：可以添加新形状而无需更改框架中的任何代码（使用工厂形状的客户端代码）。如下一节所示，某些工厂实现允许添加新产品，甚至无需修改工厂类。
[^_^]:The advantage is obvious: New shapes can be added without changing a single line of code in the framework(the client code that uses the shapes from the factory). As it is shown in the next sections, there are certain factory implementations that allow adding new products without even modifying the factory class.

### 具体问题和实现
[^_^]:### Specific problems and implementation

#### 程序解决方案- switch/case 新手实例化。
[^_^]:#### Procedural Solution - switch/case noob instantiation.

![工厂新手实现——UML类图](imgaes/factory%20noob%20implementation.gif)
[^_^]:Factory Noob Implementation - UML Class Diagram

这些也被称为参数化的工厂。可以编写生成方法，以便它可以使用条件（作为方法参数输入或从某些全局配置参数读取 - 请参阅抽象工厂模式）生成更多类型的Product对象，以标识应创建的对象的类型， 如下：
[^_^]:Those are also known as parameterized Factories. The generating method can be written so that it can generate more types of Product objects, using a condition (entered as a method parameter or read from some global configuration parameters - see abstract factory pattern) to identify the type of the object that should be created, as below:

```java
public class ProductFactory{
	public Product createProduct(String ProductID){
		if (id==ID1)
			return new OneProduct();
		if (id==ID2) return
			return new AnotherProduct();
		... // so on for the other Ids
		
        return null; //if the id doesn't have any of the expected values
    }
    ...
}
```

这个实现是最简单和直观的(我们称之为新手实现)。这里的问题是，一旦我们添加新的具体产品调用，我们应该修改Factory类。它不是很灵活，违反了开放原则。当然我们可以子类化工厂类，但是不要忘记工厂类通常用作单例。对它进行子类化意味着通过代码替换所有工厂类引用。
[^_^]:This implementation is the most simple and intuitive (Let's call it noob implementation). The problem here is that once we add a new concrete product call we should modify the Factory class. It is not very flexible and it violates open close principle. Of course we can subclass the factory class, but let's not forget that the factory class is usually used as a singleton. Subclassing it means replacing all the factory class references everywhere through the code.

### 类注册,使用反射
[^_^]:### Class Registration - using reflection

如果您可以使用反射（例如，使用Java或.NET语言），则可以将新产品类注册到工厂，而无需更改工厂本身。要在不知道对象类型的情况下在工厂类中创建对象，我们在productID和产品的类类型之间保留一个映射。在这种情况下，当将新产品添加到应用程序时，必须将其注册到工厂。此操作不需要更改工厂类代码。
[^_^]:If you can use reflection, for example in Java or .NET languages, you can register new product classes to the factory without even changing the factory itself. For creating objects inside the factory class without knowing the object type we keep a map between the productID and the class type of the product. In this case when a new product is added to the application it has to be registered to the factory. This operation doesn't require any change in the factory class code.

```java
class ProductFactory
{
	private HashMap m_RegisteredProducts = new HashMap();

	public void registerProduct (String productID, Class productClass)
	{
		m_RegisteredProducts.put(productID, productClass);
	}

	public Product createProduct(String productID)
	{
		Class productClass = (Class)m_RegisteredProducts.get(productID);
		Constructor productConstructor = cClass.getDeclaredConstructor(new Class[] { String.class });
		return (Product)productConstructor.newInstance(new Object[] { });
	}
}
```

我们可以将注册代码放在代码中的任何位置，但是在静态构造函数中的产品类中有一个方便的位置。看下面的例子：
[^_^]:We can put the registration code anywhere in our code, but a convenient place is inside the product class in a static constructor. Look at the example below:

1.在产品类别之外完成注册：
[^_^]:1. Registration done outside of product classes:

```java
	public static void main(String args[]){
		Factory.instance().registerProduct("ID1", OneProduct.class);
	}
```

2.在产品类别内完成注册：
[^_^]:2. Registration done inside the product classes:

```java
class OneProduct extends Product
{
	static {
		Factory.instance().registerProduct("ID1",OneProduct.class);
	}
	...
}
```

我们必须确保在工厂要求注册之前加载具体的产品类（如果它们未加载，它们将不会在工厂中注册，createProduct将返回null）。为了确保它，我们将在主类的静态部分中使用Class.forName方法。在加载主类之后立即执行此部分。Class.forName应该返回指定类的Class实例。如果编译器尚未加载该类，则在调用Class.forName时将加载该类。因此，每个类加载时，将执行每个类中的静态块：
[^_^]:We have to make sure that the concrete product classes are loaded before they are required by the factory for registration(if they are not loaded they will not be registered in the factory and createProduct will return null). To ensure it we are going to use the Class.forName method right in the static section of the main class. This section is executed right after the main class is loaded. Class.forName is supposed to return a Class instance of the indicated class. If the class is not loaded by the compiler yet, it will be loaded when the Class.forName is invoked. Consequently the static block in each class will be executed when each class is loaded:

```java
class Main
{
	static
	{
		try
		{
			Class.forName("OneProduct");
			Class.forName("AnotherProduct");
		}
		catch (ClassNotFoundException any)
		{
			any.printStackTrace();
		}
	}
	public static void main(String args[]) throws PhoneCallNotRegisteredException
	{
		...
	}
}
```

这个反射实现有自己的缺点。最主要的是性能。涉及反射的代码的性能甚至可以降低到非反射代码的极限的10％。另一个问题是并非所有编程语言都提供反射机制。
[^_^]:This reflection implementation has its own drawbacks. The main one is performance. When the reflection is used the performance on code involving reflection can decrease even to 10% of the poerfomance of a non reflection code. Another issue is that not all the programming languages provide reflection mechanism.

#### 类注册——避免反射
[^_^]:#### Class Registration - avoiding reflection

正如我们在上一段中看到的那样，工厂对象在内部使用HashMap来保持参数（在我们的例子中是字符串）和具体产品类之间的映射。注册是从工厂外部进行的，因为对象是使用反射创建的，所以工厂不知道对象类型。
[^_^]:As we saw in the previous paragraph the factory object uses internally a HashMap to keep the mapping between parameters (in our case Strings) and concrete products class. The registration is made from outside of the factory and because the objects are created using reflection the factory is not aware of the objects types.

我们不想使用反射,但同时我们希望减少工厂和具体产品之间的耦合。由于工厂应该不知道产品，我们必须将工厂外的对象的创建移动到了解具体产品类的对象。那将是具体的类级本身。
[^_^]:We don't want to use reflection but in the same time we want to have a reduced coupling between the factory and concrete products. Since the factory should be unaware of products we have to move the creation of objects outside of the factory to an object aware of the concrete products classes. That would be the concrete class itself.


我们在产品抽象类中添加了一个新的抽象方法。每个具体类都将实现此方法以创建与其自身相同类型的新对象。我们还必须更改注册方法，以便我们注册具体的产品对象而不是Class对象。
[^_^]:We add a new abstract method in the product abstract class. Each concrete class will implement this method to create a new object of the same type as itself. We also have to change the registration method such that we'll register concrete product objects instead of Class objects.

```java
abstract class Product
{
	public abstract Product createProduct();
	...
}

class OneProduct extends Product
{
	...
	static
	{
		ProductFactory.instance().registerProduct("ID1", new OneProduct());
	}
	public OneProduct createProduct()
	{
		return new OneProduct();
	}
	...
}


class ProductFactory
{
	public void registerProduct(String productID, Product p)    {
		m_RegisteredProducts.put(productID, p);
	}

	public Product createProduct(String productID){
		((Product)m_RegisteredProducts.get(productID)).createProduct();
	}
}
```

#### 更高级的解决方案 - 带抽象的工厂设计模式（工厂方法）
[^_^]:#### A more advanced solution - Factory design pattern with abstractions(Factory Method)

![抽象工厂设计模式——UML类图](imgaes/factory%20design%20pattern%20with%20abstractions.gif)
[^_^]:Factory Design Pattern With Abstractions - UML Class Diagram

此实现代表了类注册实现的替代方案。我们假设我们需要向应用程序添加新产品。对于程序切换案例实现，我们需要更改Factory类，而在类注册实现中，我们需要的是将类注册到工厂而不实际修改工厂类。当然这是一个灵活的解决方案。
[^_^]:This implementation represents an alternative for the class registration implementation. Let's assume we need to add a new product to the application. For the procedural switch-case implementation we need to change the Factory class, while in the class registration implementation all we need is to register the class to the factory without actually modifying the factory class. For sure this is a flexible solution.

程序实现是开放 - 闭合原则的典型坏例子。我们可以看到，避免修改Factory类的最直观的解决方案是扩展它。
[^_^]:The procedural implementation is the classical bad example for the Open-Close Principle. As we can see there the most intuitive solution to avoid modifying the Factory class is to extend it.

这是工厂方法模式的经典实现。类注册实现有一些缺点，没有太多的优点：

[^_^]:This is the classic implementation of the factory method pattern. There are some drawbacks over the class registration implementation and not so many advantages
[^_^]:The derived factory method can be changed to perform additional operations when the objects are created (maybe some initialization based on some global parameters ...).
[^_^]:The factory can not be used as a singleton.
[^_^]:Each factory has to be initialized before using it.
[^_^]:More difficult to implement.
[^_^]:If a new object has to be added a new factory has to be created.

* \+ 可以更改派生的工厂方法，以便在创建对象时执行其他操作（可能是基于某些全局参数的某些初始化...）。
* \- 工厂不能用作单例。
* \- 每个工厂在使用前都必须进行初始化。
* \- 更难实施。
* \- 如果必须添加新对象，则必须创建新工厂。

无论如何，这个经典实现的优势在于它将帮助我们理解抽象工厂的设计模式。
[^_^]:Anyway, this classic implementation has the advantage that it will help us understanding the Abstract Factory design pattern.

#### 结论：
[^_^]:#### Conclusion:

当你设计一个应用程序时，只要想想你是否真的需要一个工厂来创建对象。使用它可能会给您的应用带来不必要的复杂性。如果您有许多相同基类型的对象，并且您操作它们主要是转换为抽象类型，那么您需要一个工厂。如果你的代码应该包含如下代码的大量代码，你应该重新考虑它：
[^_^]:When you design an application just think if you really need it a factory to create objects. Maybe using it will bring unnecessary complexity in your application. If you have many objects of the same base type and you manipulate them mostly casted to abstract types, then you need a factory. If you're code should have a lot of code like the following, you should reconsider it:

```java
(if (ConcreteProduct)genericProduct typeof )
	((ConcreteProduct)genericProduct).doSomeConcreteOperation().
```

如果你决定去使用工厂模式,我建议使用一个类注册实现(有或没有反射),并避免工厂方法(带抽象的工厂设计模式)。请注意使用switch-case实现是最简单,违反开闭原则(OCP)理论。使用它的唯一明智的方法是增加临时模块，直到它被真正的工厂取代。
[^_^]:If you decided to go for a factory, I would recommend using one of class registration implementations(with or without reflection) and to avoid the Factory Method (Factory design pattern with abstractions). Please note the procedural switch-case (noob) implementation is the simplest, violates the OCP principle is used only to explain the theory. The only wise way to use it is for temporary modules until it is replaced with a real factory.