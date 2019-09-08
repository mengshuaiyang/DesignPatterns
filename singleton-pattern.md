## [����ģʽ](https://www.oodesign.com/singleton-pattern.html)
[^_^]: ## Singleton Pattern

### ����
[^_^]:### Motivation

��ʱ����ֻ��һ��ʵ���Ǻ���Ҫ�ġ����磺��ϵͳ��Ӧ��ֻ��һ�����ڹ���������ֻ��һ���ļ�ϵͳ��ֻ��һ����ӡ���ѻ����򣩡�ͨ������ģʽ�����ڼ��й����ڲ����ⲿ��Դ��Ϊ�����Լ��ṩȫ�ַ��ʵ㡣
[^_^]:Sometimes it's important to have only one instance for a class. For example, in a system there should be only one window manager (or only a file system or only a print spooler). Usually singletons are used for centralized management of internal or external resources and they provide a global point of access to themselves.

����ģʽ����򵥵����ģʽ֮һ����ֻ�漰һ������ʵ����������࣬��ȷ����������ʵ��������һ��; ͬʱ�����ṩ�˶Ը�ʵ����ȫ�ַ��ʵ㡣����������£����Դ��κεط�ʹ����ͬ��ʵ����ÿ�ζ����޷�ֱ�ӵ��ù��캯����
[^_^]:The singleton pattern is one of the simplest design patterns: it involves only one class which is responsible to instantiate itself, to make sure it creates not more than one instance; in the same time it provides a global point of access to that instance. In this case the same instance can be used from everywhere, being impossible to invoke directly the constructor each time.

###  ��ͼ
[^_^]:### Intent
[^_^]:Ensure that only one instance of a class is created.
[^_^]:Provide a global point of access to the object.

* ȷ��һ����ֻ����һ��ʵ����
* ��ϵͳ�ṩһ��ȫ�ַ��ʵ�ʵ������

### ʵ��
[^_^]:### Implementation

ʵ�ְ�������������ľ�̬��Ա,һ��˽�й��캯���;�̬������̬��Ա��������һ�����á�
[^_^]:The implementation involves a static member in the "Singleton" class, a private constructor and a static public method that returns a reference to the static member.

![����ʵ�֡���UML��ͼ](imgaes/singleton_implementation_-_uml_class_diagram.gif)
[^_^]:Singleton Implementation - UML Class Diagram


����ģʽ������һ��getInstance������¶�˶��ص�ʵ�����ʵĿͻ���getInstance()�Ǹ��𴴽����ʵ���������,��û�д����ͷ���ʵ����
[^_^]:The Singleton Pattern defines a getInstance operation which exposes the unique instance which is accessed by the clients. getInstance() is is responsible for creating its class unique instance in case it is not created yet and to return that instance.

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

ע��,������Ĵ�����getInstance��������ȷ��ֻ�д������һ��ʵ�������캯����Ӧ�ô��ⲿ��ķ���,��ȷ��ʵ�������Ψһ����ֻ��ͨ��getInstance������
[^_^]:You can notice in the above code that getInstance method ensures that only one instance of the class is created. The constructor should not be accessible from the outside of the class to ensure the only way of instantiating the class would be only through the getInstance method.

getInstance����Ҳ�ṩһ��ȫ�ֵķ��ʶ���,�������������·�ʽ:
[^_^]:The getInstance method is used also to provide a global point of access to the object and it can be used in the following manner:

```java
Singleton.getInstance().doSomething();
```

### �����Ժ�����
[^_^]:### Applicability & Examples

���ݶ��壬������ֻ��һ�����ʵ�������ұ�����Դ�ȫ�ַ��ʵ���ʿͻ���ʱ����Ӧʹ�õ���ģʽ��������ʹ�õ�����һЩʵ�����:
[^_^]:According to the definition the singleton pattern should be used when there must be exactly one instance of a class, and when it must be accessible to clients from a global access point. Here are some real situations where the singleton is used:

#### ʾ��1 - Logger��
[^_^]:#### Example 1 - Logger Classes

����ģʽ������logger�����ơ���Щ������Ϊ����ʵ�ֵģ�����������Ӧ�ó���������ṩȫ����־��¼���ʵ㣬��������ÿ��ִ����־��¼����ʱ��������
[^_^]:The Singleton pattern is used in the design of logger classes. This classes are ussualy implemented as a singletons, and provides a global logging access point in all the application components without being necessary to create an object each time a logging operations is performed.

#### ʾ��2 -Configuration��
[^_^]:#### Example 2 - Configuration Classes

����ģʽ����������ṩӦ�ó����������õ��ࡣͨ����������ʵ��Ϊ����ģʽ�����ǲ����ṩһ��ȫ�ַ��ʵ�,���һ�����������������������ʵ������ʵ������ʱ�����ȡֵʱ�����������������ڲ��ṹ�е�ֵ����������ݿ���ļ��ж�ȡֵ������Ա���ÿ��ʹ�����ò���ʱ���¼���ֵ��
[^_^]:The Singleton pattern is used to design the classes which provides the configuration settings for an application. By implementing configuration classes as Singleton not only that we provide a global access point, but we also keep the instance we use as a cache object. When the class is instantiated( or when a value is read ) the singleton will keep the values in its internal structure. If the values are read from the database or from files this avoids the reloading the values each time the configuration parameters are used.

#### ʾ��3 - �Թ���ģʽ������Դ
[^_^]:#### Example 3 - Accesing resources in shared mode

�������������Ҫʹ�ô��ж˿ڵ�Ӧ�ó��򡣼���Ӧ�ó�����������࣬�ڶ��̻߳����й�������Ҫ�ڴ��ж˿��ϲ�������������������£�����ʹ�þ���ͬ�������ĵ����������ж˿��ϵ����в�����
[^_^]:It can be used in the design of an application that needs to work with the serial port. Let's say that there are many classes in the application, working in an multi-threading environment, which needs to operate actions on the serial port. In this case a singleton with synchronized methods could be used to be used to manage all the operations on the serial port.

#### ʾ��4 - ����ʵ��Ϊ����
[^_^]:#### Example 4 - Factories implemented as Singletons

�����������һ�����й�����Ӧ�ó����Ա��ڶ��̻߳�����ʹ�����ǵ�id�����¶���Acount��Customer��Site��Address�������������2����ͬ���߳���ʵ�������Σ��������2���ص���ID����2����ͬ�Ķ���������ǽ�Factory��Ϊ����ʵ�֣����Ǿͱ�����������⡣��ϳ��󹤳��򹤳������͵������ģʽ��һ�ֳ�����������
[^_^]:Let's assume that we design an application with a factory to generate new objects(Acount, Customer, Site, Address objects) with their ids, in an multithreading environment. If the factory is instantiated twice in 2 different threads then is possible to have 2 overlapping ids for 2 different objects. If we implement the Factory as a singleton we avoid this problem. Combining Abstract Factory or Factory Method and Singleton design patterns is a common practice.

### ���������ʵ��
[^_^]:### Specific problems and implementation

#### ���ڶ��̵߳��̰߳�ȫʵ��
[^_^]:#### Thread-safe implementation for multi-threading use.

һ����׳�ĵ���ʵ��Ӧ���������κ������������Ϊʲô������Ҫȷ�����ڶ��߳�ʹ����ʱ������ԭ����ǰ���ʾ����ʾ����������ר�����ڶ��߳�Ӧ�ó�����ȷ����/дͬ����

[^_^]:A robust singleton implementation should work in any conditions. This is why we need to ensure it works when multiple threads uses it. As seen in the previous examples singletons can be used specifically in multi-threaded application to make sure the reads/writes are synchronized.

ʹ��˫�����Ƶ��ӳ�ʵ������
[^_^]:Lazy instantiation using double locking mechanism.

�����������ʾ�ı�׼ʵ����һ���̰߳�ȫ��ʵ�֣�����������õ��̰߳�ȫʵ�֣���Ϊ������̸������ʱ��ͬ���ǳ��������ǿ��Կ������ڳ�ʼ������󣬲���Ҫ���ͬ������getInstance��ͬ����������ǿ������������Ѿ�����������ֻ��Ҫ�ڲ�ʹ���κ�ͬ���������·��������������Ϊ�գ�������ټ�鲢��ͬ�����д�����������Ż����������ͬ���顣���Ϊ˫���������ơ�
[^_^]:The standard implementation shown in the above code is a thread safe implementation, but it's not the best thread-safe implementation beacuse synchronization is very expensive when we are talking about the performance. We can see that the synchronized method getInstance does not need to be checked for syncronization after the object is initialized. If we see that the singleton object is already created we just have to return it without using any syncronized block. This optimization consist in checking in an unsynchronized block if the object is null and if not to check again and create it in an syncronized block. This is called double locking mechanism.

���������������´�������ʵ������getInstance()����ʱ��һ�Ρ�������ӳ�ʵ����,��ȷ����ֻ������Ҫʱ��������ʵ����
[^_^]:In this case case the singleton instance is created when the getInstance() method is called for the first time. This is called lazy instantiation and it ensures that the singleton instance is created only when it is needed.

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

������[https://www.ibm.com/developerworks/java/library/j-dcl/index.html](https://www.ibm.com/developerworks/java/library/j-dcl/index.html)���ҵ�һ������˫���������Ƶ����¡�
[^_^]:A detialed discussion(double locking mechanism) can be found on http://www-128.ibm.com/developerworks/java/library/j-dcl.html?loc=j

##### ���ڵ�ʵ����ͨ��ʹ�þ�̬�ֶ���ʵ��
[^_^]:#####Early instantiation using implementation with static field

�������ʵ���У����������ڼ�����ʱʵ�������������ڵ�һ��ʹ��ʱʵ��������Ϊʵ����Ա������Ϊstatic�������Ϊʲô��������������ǲ���Ҫͬ��������κβ��֡�һ���Ᵽ֤�˶����Ψһ�ԣ��ͻ���ظ��ࡣ
[^_^]:In the following implementattion the singleton object is instantiated when the class is loaded and not when it is first used, due to the fact that the instance member is declared static. This is why in we don't need to synchronize any portion of the code in this case. The class is loaded once this guarantee the uniquity of the object.

������һ���򵥵�����(java)
[^_^]:Singleton - A simple example (java)

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

#### �ܱ����Ĺ��캯��
[^_^]:#### Protected constructor
[^_^]:It is possible to use a protected constructor to in order to permit the subclassing of the singeton. This techique has 2 drawbacks that makes singleton inheritance impractical:
[^_^]: *First of all, if the constructor is protected, it means that the class can be instantiated by calling the constructor from another class in the same package. A possible solution to avoid it is to create a separate package for the singleton.
[^_^]: *Second of all, in order to use the derived class all the getInstance calls should be changed in the existing code from Singleton.getInstance() to NewSingleton.getInstance().

����ʹ���ܱ����Ĺ��캯��������singeton�����໯�����ּ�����2��ȱ��,ʹ�õ����̳в���ʵ�ʵģ�
* ����,������캯���ܵ�����������ζ�ſ���ͨ����ͬһ�����е���һ������ù��캯����ʵ�������ࡣ�������Ŀ��ܽ��������Ϊ�������������İ���
* ��Σ�Ϊ��ʹ�������࣬����getInstance���ö�Ӧ�������д����д�Singleton.getInstance()����ΪNewSingleton.getInstance()��



#### ����ɲ�ͬ����������ص�����ʵ����������ֶ������ʵ����
[^_^]:#### Multiple singleton instances if classes loaded by different classloaders access a singleton.

���һ����(ͬ��������,ͬ���İ�)����������ͬ����������������Ǵ��������ֲ�ͬclasess���ڴ��С�
[^_^]:If a class(same name, same package) is loaded by 2 diferent classloaders they represent 2 different clasess in memory.

#### ���л�
[^_^]:#### Serialization

��java�У����Singleton��ʵ��java.io.Serializable�ӿڣ����������л�Ȼ�����л����ʱ�����ᴴ��Singleton��Ķ��ʵ����Ϊ�˱������������Ӧ��ʵ��readResolve�����������javadocs�е�Serializable()��readResolve() ������
[^_^]:In java, if a Singleton class implements the java.io.Serializable interface, when the singleton is serialized and then deserialized more than once, there will be multiple instances of the Singleton class created. In order to avoid this the readResolve method should be implemented. See Serializable () and readResolve Method () in javadocs.

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

#### ���󹤳��͹���������Ϊ����ʵ�֡�
[^_^]:#### Abstract Factory and Factory Methods implemented as singletons.

��ĳЩ�����,����Ӧ����Ψһ�ġ���������ʱ����2���������ܻ��������Ӱ�졣ȷ�������Ƕ�һ�޶���Ӧ������Ϊһ������ʵ�֡�ͨ�������������ǻ�������ʹ����֮ǰʵ�������ࡣ
[^_^]:There are certain situations when the a factory should be unique. Having 2 factories might have undesired effects when objects are created. To ensure that a factory is unique it should be implemented as a singleton. By doing so we also avoid to instantiate the class before using it.

#### �ȵ�:
[^_^]:#### Hot Spot:

[^_^]: Multithreading - A special care should be taken when singleton has to be used in a multithreading application.
Serialization - When Singletons are implementing Serializable interface they have to implement readResolve method in order to avoid having 2 different objects.
[^_^]: Classloaders - If the Singleton class is loaded by 2 different class loaders we'll have 2 different classes, one for each class loader.
[^_^]: Global Access Point represented by the class name - The singleton instance is obtained using the class name. At the first view this is an easy way to access it, but it is not very flexible. If we need to replace the Sigleton class, all the references in the code should be changed accordinglly.

* ���߳� - �����������ڶ��߳�Ӧ�ó�����ʹ��ʱ��Ӧ�ر�С�ġ�
* ���л� - ��Singletonsʵ��Serializable�ӿ�ʱ�����Ǳ���ʵ��readResolve�������Ա�����2����ͬ�Ķ���
* ������� - ���Singleton����2����ͬ������������أ����ǽ���2����ͬ���࣬ÿ���������һ����
* ��������ʾ��ȫ�ַ��ʵ� - ʹ��������ȡ����ʵ�����ڵ�һ����ͼ�У�����һ�ַ������ļ򵥷������������Ǻ������������Ҫ�滻Sigleton�࣬��Ӧ�ø��ݴ�����Ĵ����е��������á�
