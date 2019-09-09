## [抽象工厂模式](https://www.oodesign.com/abstract-factory-pattern.html)
## Abstract Factory

### 动机
### Motivation

模块化是一个大问题在今天的节目。世界各地的程序员正在试图避免将代码添加到现有类的概念,以使他们支持封装更一般的信息。把信息管理人员管理的情况下电话号码。电话号码有一个特定的规则,他们会生成根据地区和国家。如果在某种程度上应用程序应该改变为了支持添加数字组成一个新国家,应用程序的代码必须改变,它会变得越来越复杂。
Modularization is a big issue in today's programming. Programmers all over the world are trying to avoid the idea of adding code to existing classes in order to make them support encapsulating more general information. Take the case of a information manager which manages phone number. Phone numbers have a particular rule on which they get generated depending on areas and countries. If at some point the application should be changed in order to support adding numbers form a new country, the code of the application would have to be changed and it would become more and more complicated.

为了防止它,使用抽象工厂设计模式。使用这种模式定义一个框架,遵循一般模式和生产对象在运行时这个工厂是搭配任何具体工厂生产对象,遵循一定的模式的国家。换句话说,抽象工厂是super-factory创建其他工厂(工厂的工厂)。
In order to prevent it, the Abstract Factory design pattern is used. Using this pattern a framework is defined, which produces objects that follow a general pattern and at runtime this factory is paired with any concrete factory to produce objects that follow the pattern of a certain country. In other words, the Abstract Factory is a super-factory which creates other factories (Factory of factories).

### 意图
### Intent

抽象工厂提供创建一系列相关对象的接口,没有显式地指定他们的类。
Abstract Factory offers the interface for creating a family of related objects, without explicitly specifying their classes.

### 实现
### Implementation

基本工作模式如下所示,在UML图:
The pattern basically works as shown below, in the UML diagram:

![抽象工厂实现——UML类图](imgaes/abstract-factory-pattern.png)
Abstract Factory Implementation - UML Class Diagram 

参与抽象工厂模式的类有:
The classes that participate to the Abstract Factory pattern are:

AbstractFactory——声明一个接口来创建抽象产品的操作。
AbstractFactory - declares a interface for operations that create abstract products.
ConcreteFactory——实现操作来创建具体产品。
ConcreteFactory - implements operations to create concrete products.
AbstractProduct——声明一个接口类型的产品对象。
AbstractProduct - declares an interface for a type of product objects.
产品——定义了一个由相应的ConcreteFactory;它实现了AbstractProduct接口。
Product - defines a product to be created by the corresponding ConcreteFactory; it implements the AbstractProduct interface.
客户端使用的接口声明的AbstractFactory和AbstractProduct类。
Client - uses the interfaces declared by the AbstractFactory and AbstractProduct classes.

AbstractFactory类是确定具体对象的实际类型并创建它,但它返回一个抽象的指针指向刚刚创建的具体对象。这决定了客户的行为,要求工厂创建一个对象的特定的抽象类型和返回抽象指针指向它,阻止客户端知道任何关于实际对象的创建。
The AbstractFactory class is the one that determines the actual type of the concrete object and creates it, but it returns an abstract pointer to the concrete object just created. This determines the behavior of the client that asks the factory to create an object of a certain abstract type and to return the abstract pointer to it, keeping the client from knowing anything about the actual creation of the object.

这一事实抽象工厂返回一个指针创建的对象意味着客户端没有知识的对象的类型。这意味着不需要包括任何类声明有关的具体类型,客户随时处理抽象类型。创建的对象的具体类型,工厂,由客户机访问只能通过抽象接口。
The fact that the factory returns an abstract pointer to the created object means that the client doesn't have knowledge of the object's type. This implies that there is no need for including any class declarations relating to the concrete type, the client dealing at all times with the abstract type. The objects of the concrete type, created by the factory, are accessed by the client only through the abstract interface.

创建对象的方法的第二个含义是,当添加新的混凝土类型是必要的,我们要做的是修改客户端代码,让它使用不同的工厂,这是容易得多比实例化一个新的类型,这需要更改代码创建一个新对象的地方。
The second implication of this way of creating objects is that when the adding new concrete types is needed, all we have to do is modify the client code and make it use a different factory, which is far easier than instantiating a new type, which requires changing the code wherever a new object is created.

的经典实现抽象工厂模式如下:
The classic implementation for the Abstract Factory pattern is the following:

```java
abstract class AbstractProductA{
	public abstract void operationA1();
	public abstract void operationA2();
}

class ProductA1 extends AbstractProductA{
	ProductA1(String arg){
		System.out.println("Hello "+arg);
	} // Implement the code here
	public void operationA1() { };
	public void operationA2() { };
}

class ProductA2 extends AbstractProductA{
	ProductA2(String arg){
		System.out.println("Hello "+arg);
	} // Implement the code here
	public void operationA1() { };
	public void operationA2() { };
}

abstract class AbstractProductB{
	//public abstract void operationB1();
	//public abstract void operationB2();
}

class ProductB1 extends AbstractProductB{
	ProductB1(String arg){
		System.out.println("Hello "+arg);
	} // Implement the code here
}

class ProductB2 extends AbstractProductB{
	ProductB2(String arg){
		System.out.println("Hello "+arg);
	} // Implement the code here
}

abstract class AbstractFactory{
	abstract AbstractProductA createProductA();
	abstract AbstractProductB createProductB();
}

class ConcreteFactory1 extends AbstractFactory{
	AbstractProductA createProductA(){
		return new ProductA1("ProductA1");
	}
	AbstractProductB createProductB(){
		return new ProductB1("ProductB1");
	}
}

class ConcreteFactory2 extends AbstractFactory{
	AbstractProductA createProductA(){
		return new ProductA2("ProductA2");
	}
	AbstractProductB createProductB(){
		return new ProductB2("ProductB2");
	}
}

//Factory creator - an indirect way of instantiating the factories
class FactoryMaker{
	private static AbstractFactory pf=null;
	static AbstractFactory getFactory(String choice){
		if(choice.equals("a")){
			pf=new ConcreteFactory1();
		}else if(choice.equals("b")){
				pf=new ConcreteFactory2();
			} return pf;
	}
}

// Client
public class Client{
	public static void main(String args[]){
		AbstractFactory pf=FactoryMaker.getFactory("a");
		AbstractProductA product=pf.createProductA();
		//more function calls on product
	}
}
```

### 适用性和例子
### Applicability & Examples

我们应该使用抽象工厂设计模式:
We should use the Abstract Factory design pattern when:

系统需要独立于与创建产品的工作方式。
the system needs to be independent from the way the products it works with are created.
　　系统应该配置或使用多个系列的产品。
the system is or should be configured to work with multiple families of products.
　　一个家庭的产品设计工作。
a family of products is designed to work only all together.
建立一个图书馆的产品是必要的,只有相关的接口,而不是实现。
the creation of a library of products is needed, for which is relevant only the interface, not the implementation, too.

#### 电话的例子
#### Phone Number Example

这个例子在文章的开头可以扩展到地址,。AbstractFactory类将包含方法用于创建新条目的信息经理的电话号码和地址,方法,生产地址和PhoneNumber抽象产品,属于AbstractProduct类。AbstractProduct类将定义方法,这些产品支持:为get和set方法的地址,城市,地区和邮政编码和电话号码数量获取和设置方法。
The example at the beginning of the article can be extended to addresses, too. The AbstractFactory class will contain methods for creating a new entry in the information manager for a phone number and for an address, methods that produce the abstract products Address and PhoneNumber, which belong to AbstractProduct classes. The AbstractProduct classes will define methods that these products support: for the address get and set methods for the street, city, region and postal code members and for the phone number get and set methods for the number.

ConcreteFactory和ConcreteProduct类将实现上面定义的接口,并将出现在我们的示例的形式USAddressFactory类和USAddress USPhoneNumber类。为每一个新的国家,需要添加到应用程序中,一组新的具体类型类将被添加。这样我们可以EnglandAddressFactory和EnglandAddress EnglandPhoneNumber文件的英文地址信息。
The ConcreteFactory and ConcreteProduct classes will implement the interfaces defined above and will appear in our example in the form of the USAddressFactory class and the USAddress and USPhoneNumber classes. For each new country that needs to be added to the application, a new set of concrete-type classes will be added. This way we can have the EnglandAddressFactory and the EnglandAddress and EnglandPhoneNumber that are files for English address information.


#### 披萨工厂的例子
#### Pizza Factory Example

另一个例子,这一次更简单和容易理解,是披萨的一个工厂,它定义了方法名和返回类型不同种类的披萨。抽象工厂可以叫AbstractPizzaFactory RomeConcretePizzaFactory MilanConcretePizzaFactory被两个抽象类的扩展。抽象工厂将定义类型的比萨饼浇头,像意大利辣香肠,香肠或鳀鱼,和具体的工厂只能实现一组浇头,特定的地区,即使一个一流的实现在两个具体工厂,由此产生的披萨将不同的子类,每个的区域中实现。
Another example, this time more simple and easier to understand, is the one of a pizza factory, which defines method names and returns types to make different kinds of pizza. The abstract factory can be named AbstractPizzaFactory, RomeConcretePizzaFactory and MilanConcretePizzaFactory being two extensions of the abstract class. The abstract factory will define types of toppings for pizza, like pepperoni, sausage or anchovy, and the concrete factories will implement only a set of the toppings, which are specific for the area and even if one topping is implemented in both concrete factories, the resulting pizzas will be different subclasses, each for the area it was implemented in.


#### 外观和感觉的例子
#### Look & Feel Example

外观和感觉抽象工厂是最常见的例子。例如,GUI框架应该支持几个外观主题,如主题和窗户看。每种风格定义了每种类型的不同的外观和行为控制:按钮、编辑框。为了避免hardociding为每种类型的控制我们定义一个抽象类LookAndFeel。这个调用将实例化,这取决于应用程序的配置参数的一个具体的工厂:WindowsLookAndFeel或MotifLookAndFeel。每个请求一个新对象将委托给instatiated混凝土工厂将返回控制特定的味道
Look & Feel Abstract Factory is the most common example. For example, a GUI framework should support several look and feel themes, such as Motif and Windows look. Each style defines different looks and behaviors for each type of controls: Buttons and Edit Boxes. In order to avoid the hardociding it for each type of control we define an abstract class LookAndFeel. This calls will instantiate, depending on a configuration parameter in the application one of the concrete factories: WindowsLookAndFeel or MotifLookAndFeel. Each request for a new object will be delegated to the instatiated concrete factory which will return the controls with the specific flavor

![抽象工厂的例子——UML类图](imgaes/abstract-factory-pattern-example.png)
Abstract Factory Example - UML Class Diagram 

### 具体问题和实现
### Specific problems and implementation

抽象工厂模式既有优点和缺点。一方面它从客户端隔离对象的创建,需要他们,给予客户只有通过一个接口访问他们的可能性,使操作更容易。产品的交换家庭更容易,一个具体工厂类的出现在代码只有在它被实例化。如果一个家庭的产品是为了一起工作,抽象工厂使它易于使用的对象只有一个家庭。另一方面,新产品添加到现有的工厂是困难的,因为抽象工厂接口使用一组固定的产品,可以被创建。这就是为什么添加一个新产品意味着扩展工厂接口,包括AbstractFactory类及其子类的变化。本节将讨论的方法实现的模式,以避免可能出现的问题。
The Abstract Factory pattern has both benefits and flaws. On one hand it isolates the creation of objects from the client that needs them, giving the client only the possibility of accessing them through an interface, which makes the manipulation easier. The exchanging of product families is easier, as the class of a concrete factory appears in the code only where it is instantiated. Also if the products of a family are meant to work together, the Abstract Factory makes it easy to use the objects from only one family at a time. On the other hand, adding new products to the existing factories is difficult, because the Abstract Factory interface uses a fixed set of products that can be created. That is why adding a new product would mean extending the factory interface, which involves changes in the AbstractFactory class and all its subclasses. This section will discuss ways of implementing the pattern in order to avoid the problems that may appear.


#### 工厂单例
#### Factories as singletons
应用程序通常需要每个家庭只有一个ConcreteFactory类的实例产品。这意味着,最好是单例实现它。
An application usually needs only one instance of the ConcreteFactory class per family product. This means that it is best to implement it as a Singleton.


#### 创建产品
#### Creating the products

AbstractFactory类只声明了接口用于创建产品。它的任务是ConcreteProduct类来创建产品。为每个家庭最好的主意是运用工厂方法设计模式。一个具体的工厂将指定其产品通过重写他们每个人的工厂方法。即使实现可能看起来简单,使用这个想法将意味着每个产品定义一个新的具体工厂子类的家庭,即使类在大多数方面是相似的。
The AbstractFactory class only declares the interface for creating the products. It is the task of the ConcreteProduct class to actually create the products. For each family the best idea is applying the Factory Method design pattern. A concrete factory will specify its products by overriding the factory method for each of them. Even if the implementation might seem simple, using this idea will mean defining a new concrete factory subclass for each product family, even if the classes are similar in most aspects.

为简化代码,提高性能的原型可以用来代替工厂方法设计模式,尤其是当有许多产品的家庭。在这种情况下,混凝土工厂启动每个产品在家庭的一个典型的实例时,需要一个新的而不是创建,现有的原型是克隆。这种方法不需要一个新的混凝土工厂为每个新系列产品。
For simplifying the code and increase the performance the Prototype design pattern can be used instead of Factory Method, especially when there are many product families. In this case the concrete factory is initiated with a prototypical instance of each product in the family and when a new one is needed instead of creating it, the existing prototype is cloned. This approach eliminates the need for a new concrete factory for each new family of products.


#### 扩大工厂
#### Extending the factories
的操作改变工厂为了支持新产品的创造并不容易。可以做些什么来解决这个问题,而不是CreateProduct每个产品的方法,使用一个单一的创建方法需要一个参数,确定产品所需的类型。这种方法更灵活,但更不安全。问题是创建方法返回的所有对象都有相同的接口,这是一个对应于创建方法和客户端返回的类型并不总是能够正确检测类实例实际上所属。
The operation of changing a factory in order for it to support the creation of new products is not easy. What can be done to solve this problem is, instead of a CreateProduct method for each product, to use a single Create method that takes a parameter that identifies the type of product needed. This approach is more flexible, but less secure. The problem is that all the objects returned by the Create method will have the same interface, that is the one corresponding to the type returned by the Create method and the client will not always be able to correctly detect to which class the instance actually belongs.

### 热点:
### Hot Points:

AbstractFactory类声明只有一个接口用于创建产品。实际创建的任务ConcreteProduct类,在一个好的方法是运用工厂方法设计模式为每个家庭的产物。
AbstractFactory class declares only an interface for creating the products. The actual creation is the task of the ConcreteProduct classes, where a good approach is applying the Factory Method design pattern for each product of the family.

扩展工厂可以通过使用一个创建方法对所有的产品和附加产品的类型需要的信息。
Extending factories can be done by using one Create method for all products and attaching information about the type of product needed.