# [单例模式](https://www.oodesign.com/singleton-pattern.html) #
<!-- # Singleton Pattern # -->

## 动机 ##
<!-- ## Motivation ## -->

有时侯类只有一个实例是很重要的。例如：在系统中应该只有一个窗口管理器（或只有一个文件系统或只有一个打印假脱机程序）。通常单例模式被用于集中管理内部或外部资源，为他们自己提供全局访问点。
<!-- Sometimes it's important to have only one instance for a class. For example, in a system there should be only one window manager (or only a file system or only a print spooler). Usually singletons are used for centralized management of internal or external resources and they provide a global point of access to themselves. -->

单例模式是最简单的设计模式之一：它只涉及一个负责实例化自身的类，以确保它创建的实例不超过一个; 同时，它提供了对该实例的全局访问点。在这种情况下，可以从任何地方使用相同的实例，每次都是无法直接调用构造函数。
<!-- The singleton pattern is one of the simplest design patterns: it involves only one class which is responsible to instantiate itself, to make sure it creates not more than one instance; in the same time it provides a global point of access to that instance. In this case the same instance can be used from everywhere, being impossible to invoke directly the constructor each time. -->

## 意图 ##
<!-- ## Intent ## -->

* 确保一个类只创建一个实例。
<!-- Ensure that only one instance of a class is created. -->
* 对系统提供一个全局访问的实例对象。
<!-- Provide a global point of access to the object. -->

## 实现 ##
<!-- ## Implementation ## -->

实现包括“单例”类的静态成员,一个私有构造函数和静态公共静态成员方法返回一个引用。
<!-- The implementation involves a static member in the "Singleton" class, a private constructor and a static public method that returns a reference to the static member. -->

![单例实现——UML类图](images/singleton_implementation_-_uml_class_diagram.gif)
<!-- Singleton Implementation - UML Class Diagram -->

单例模式定义了一个getInstance操作暴露了独特的实例访问的客户。getInstance()是负责创建类的实例的情况下,还没有创建和返回实例。
<!-- The Singleton Pattern defines a getInstance operation which exposes the unique instance which is accessed by the clients. getInstance() is is responsible for creating its class unique instance in case it is not created yet and to return that instance. -->

```java
class Singleton {
	private static Singleton instance;

	private Singleton() {
		...
	}
	
	public static synchronized Singleton getInstance(){

		if (instance == null)
			instance = new Singleton();

		return instance;
	}
	
	...
	
	public void doSomething()
	{
		...
	}
}
```

注意,在上面的代码中getInstance方法可以确保只有创建类的一个实例。构造函数不应该从外部类的访问,以确保实例化类的唯一方法只有通过getInstance方法。
<!-- You can notice in the above code that getInstance method ensures that only one instance of the class is created. The constructor should not be accessible from the outside of the class to ensure the only way of instantiating the class would be only through the getInstance method. -->

getInstance方法也提供一个全局的访问对象,它可以用在以下方式:
<!-- The getInstance method is used also to provide a global point of access to the object and it can be used in the following manner: -->

```java
Singleton.getInstance().doSomething();
```

## 适用性和例子 ##
<!-- ## Applicability & Examples ## -->

根据定义，当必须只有一个类的实例，并且必须可以从全局访问点访问客户端时，才应使用单例模式。以下是使用单例的一些实际情况:
<!-- According to the definition the singleton pattern should be used when there must be exactly one instance of a class, and when it must be accessible to clients from a global access point. Here are some real situations where the singleton is used: -->

### 示例1 - Logger类 ###
<!-- ### Example 1 - Logger Classes ### -->

单例模式被用于logger类的设计。这些类是作为单例实现的，并且在所有应用程序组件中提供全局日志记录访问点，而无需在每次执行日志记录操作时创建对象。
<!-- The Singleton pattern is used in the design of logger classes. This classes are ussualy implemented as a singletons, and provides a global logging access point in all the application components without being necessary to create an object each time a logging operations is performed. -->

### 示例2 -Configuration类 ###
<!-- ### Example 2 - Configuration Classes ### -->

单例模式被用于设计提供应用程序配置设置的类。通过将配置类实现为单例模式，我们不仅提供一个全局访问点,而且还保留了我们用作缓存对象的实例。当实例化类时（或读取值时），单例将保持其内部结构中的值。如果从数据库或文件中读取值，则可以避免每次使用配置参数时重新加载值。
<!-- The Singleton pattern is used to design the classes which provides the configuration settings for an application. By implementing configuration classes as Singleton not only that we provide a global access point, but we also keep the instance we use as a cache object. When the class is instantiated( or when a value is read ) the singleton will keep the values in its internal structure. If the values are read from the database or from files this avoids the reloading the values each time the configuration parameters are used. -->

### 示例3 - 以共享模式访问资源 ###
<!-- ### Example 3 - Accesing resources in shared mode ### -->

它可用于设计需要使用串行端口的应用程序。假设应用程序中有许多类，在多线程环境中工作，需要在串行端口上操作操作。在这种情况下，可以使用具有同步方法的单例来管理串行端口上的所有操作。
<!-- It can be used in the design of an application that needs to work with the serial port. Let's say that there are many classes in the application, working in an multi-threading environment, which needs to operate actions on the serial port. In this case a singleton with synchronized methods could be used to be used to manage all the operations on the serial port. -->

### 示例4 - 工厂实现为单例 ###
<!-- ### Example 4 - Factories implemented as Singletons ### -->

假设我们设计一个带有工厂的应用程序，以便在多线程环境中使用它们的id生成新对象（Acount，Customer，Site，Address）。如果工厂在2个不同的线程中实例化两次，则可能有2个重叠的ID用于2个不同的对象。如果我们将Factory作为单例实现，我们就避免了这个问题。结合抽象工厂或工厂方法和单例设计模式是一种常见的做法。
<!-- Let's assume that we design an application with a factory to generate new objects(Acount, Customer, Site, Address objects) with their ids, in an multithreading environment. If the factory is instantiated twice in 2 different threads then is possible to have 2 overlapping ids for 2 different objects. If we implement the Factory as a singleton we avoid this problem. Combining Abstract Factory or Factory Method and Singleton design patterns is a common practice. -->

## 具体问题和实现 ##
<!-- ### Specific problems and implementation -->

### 用于多线程的线程安全实现 ###
<!-- ### Thread-safe implementation for multi-threading use. ### -->

一个健壮的单例实现应该适用于任何条件。这就是为什么我们需要确保它在多线程使用它时工作的原因。如前面的示例所示，单例可以专门用于多线程应用程序，以确保读/写同步。

<!-- A robust singleton implementation should work in any conditions. This is why we need to ensure it works when multiple threads uses it. As seen in the previous examples singletons can be used specifically in multi-threaded application to make sure the reads/writes are synchronized. -->

使用双锁机制的延迟实例化。
<!-- Lazy instantiation using double locking mechanism. -->

上面代码中显示的标准实现是一个线程安全的实现，但它不是最好的线程安全实现，因为当我们谈论性能时，同步非常昂贵。我们可以看到，在初始化对象后，不需要检查同步方法getInstance的同步。如果我们看到单例对象已经创建，我们只需要在不使用任何同步块的情况下返回它。如果对象为空，如果不再检查并在同步块中创建它，则此优化包括检入非同步块。这称为双重锁定机制。
<!-- The standard implementation shown in the above code is a thread safe implementation, but it's not the best thread-safe implementation beacuse synchronization is very expensive when we are talking about the performance. We can see that the synchronized method getInstance does not need to be checked for syncronization after the object is initialized. If we see that the singleton object is already created we just have to return it without using any syncronized block. This optimization consist in checking in an unsynchronized block if the object is null and if not to check again and create it in an syncronized block. This is called double locking mechanism. -->

在这种情况下情况下创建单例实例调用getInstance()方法时第一次。这叫做延迟实例化,它确保了只有在需要时创建单例实例。
<!-- In this case case the singleton instance is created when the getInstance() method is called for the first time. This is called lazy instantiation and it ensures that the singleton instance is created only when it is needed. -->

```java
//Lazy instantiation using double locking mechanism.
class Singleton
{
	private static Singleton instance;

	private Singleton()
	{
	System.out.println("Singleton(): Initializing Instance");
	}

	public static Singleton getInstance()
	{
		if (instance == null)
		{
			synchronized(Singleton.class)
			{
				if (instance == null)
				{
					System.out.println("getInstance(): First time getInstance was invoked!");
					instance = new Singleton();
				}
			}            
		}

		return instance;
	}

	public void doSomething()
	{
		System.out.println("doSomething(): Singleton does something!");
	}
}
```

可以在[https://www.ibm.com/developerworks/java/library/j-dcl/index.html](https://www.ibm.com/developerworks/java/library/j-dcl/index.html)上找到一个讨论双重锁定机制的文章。
<!-- A detialed discussion(double locking mechanism) can be found on http://www-128.ibm.com/developerworks/java/library/j-dcl.html?loc=j -->

#### 早期的实例化通过使用静态字段来实现 ####
<!-- ####Early instantiation using implementation with static field #### -->

在下面的实现中，单例对象在加载类时实例化，而不是在第一次使用时实例化，因为实例成员被声明为static。这就是为什么在这种情况下我们不需要同步代码的任何部分。一旦这保证了对象的唯一性，就会加载该类。
<!-- In the following implementattion the singleton object is instantiated when the class is loaded and not when it is first used, due to the fact that the instance member is declared static. This is why in we don't need to synchronize any portion of the code in this case. The class is loaded once this guarantee the uniquity of the object. -->

单例：一个简单的例子(java)
<!-- Singleton - A simple example (java) -->

```java
//Early instantiation using implementation with static field.
class Singleton
{
	private static Singleton instance = new Singleton();

	private Singleton()
	{
		System.out.println("Singleton(): Initializing Instance");
	}

	public static Singleton getInstance()
	{    
		return instance;
	}

	public void doSomething()
	{
		System.out.println("doSomething(): Singleton does something!");
	}
}
```

### 受保护的构造函数 ###
<!-- ### Protected constructor ### -->

可以使用受保护的构造函数以允许singeton的子类化。这种技术有2的缺点,使得单例继承不切实际的：
<!-- It is possible to use a protected constructor to in order to permit the subclassing of the singeton. This techique has 2 drawbacks that makes singleton inheritance impractical: -->
* 首先,如果构造函数受到保护，则意味着可以通过从同一个包中的另一个类调用构造函数来实例化该类。避免它的可能解决方案是为单例创建单独的包。
<!-- *First of all, if the constructor is protected, it means that the class can be instantiated by calling the constructor from another class in the same package. A possible solution to avoid it is to create a separate package for the singleton. -->
* 其次，为了使用派生类，所有getInstance调用都应该在现有代码中从Singleton.getInstance()更改为NewSingleton.getInstance()。
<!-- *Second of all, in order to use the derived class all the getInstance calls should be changed in the existing code from Singleton.getInstance() to NewSingleton.getInstance(). -->

### 如果由不同类加载器加载的类访问单例，则会出现多个单例实例 ###
<!-- ### Multiple singleton instances if classes loaded by different classloaders access a singleton. ### -->

如果一个类(同样的名字,同样的包)是由两个不同的类加载器加载它们代表了两种不同clasess在内存中。
<!-- If a class(same name, same package) is loaded by 2 diferent classloaders they represent 2 different clasess in memory. -->

### 序列化 ###
<!-- ### Serialization ### -->

在java中，如果Singleton类实现java.io.Serializable接口，当单例序列化然后反序列化多次时，将会创建Singleton类的多个实例。为了避免这种情况，应该实现readResolve方法。请参阅javadocs中的Serializable()和readResolve() 方法。
<!-- In java, if a Singleton class implements the java.io.Serializable interface, when the singleton is serialized and then deserialized more than once, there will be multiple instances of the Singleton class created. In order to avoid this the readResolve method should be implemented. See Serializable () and readResolve Method () in javadocs. -->

```java
public class Singleton implements Serializable {
	...

	// This method is called immediately after an object of this class is deserialized.
	// This method returns the singleton instance.
	protected Object readResolve() {
		return getInstance();
	}
	}

	...
```

### 抽象工厂和工厂方法作为单例实现 ###
<!-- ### Abstract Factory and Factory Methods implemented as singletons. ### -->

在某些情况下,工厂应该是唯一的。创建对象时，有2个工厂可能会产生不良影响。确保工厂是独一无二的应该是作为一个单例实现。通过这样做，我们还避免在使用它之前实例化该类。
<!-- There are certain situations when the a factory should be unique. Having 2 factories might have undesired effects when objects are created. To ensure that a factory is unique it should be implemented as a singleton. By doing so we also avoid to instantiate the class before using it. -->

### 热点 ###
<!-- ### Hot Spot: ### -->

* 多线程 - 当单例必须在多线程应用程序中使用时，应特别小心。
<!-- Multithreading - A special care should be taken when singleton has to be used in a multithreading application. -->
* 序列化 - 当Singletons实现Serializable接口时，他们必须实现readResolve方法，以避免有2个不同的对象。
<!--Serialization - When Singletons are implementing Serializable interface they have to implement readResolve method in order to avoid having 2 different objects. -->
* 类加载器 - 如果Singleton类由2个不同的类加载器加载，我们将有2个不同的类，每个类加载器一个。
<!-- Classloaders - If the Singleton class is loaded by 2 different class loaders we'll have 2 different classes, one for each class loader. -->
* 由类名表示的全局访问点 - 使用类名获取单例实例。在第一个视图中，这是一种访问它的简单方法，但它不是很灵活。如果我们需要替换Sigleton类，则应该根据代码更改代码中的所有引用。
<!-- Global Access Point represented by the class name - The singleton instance is obtained using the class name. At the first view this is an easy way to access it, but it is not very flexible. If we need to replace the Sigleton class, all the references in the code should be changed accordinglly. -->
