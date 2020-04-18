# [接口隔离原则(ISP)](https://www.oodesign.com/interface-segregation-principle.html) #
<!-- # Interface Segregation Principle (ISP) # -->

## 动机 ##
<!-- ## Motivation ## -->

在设计应用程序时，应注意如何使包含多个子模块的模块抽象。考虑到由类实现的模块，我们可以对接口中完成的系统进行抽象。但是，如果要扩展应用程序，添加另一个仅包含原始系统子模块的模块，则必须实现完整接口并编写一些虚拟方法。这种接口称为臃肿接口或污染接口。使接口污染不是一个好的解决方案，并且可能导致系统出现不良行为。
<!-- When we design an application we should take care how we are going to make abstract a module which contains several submodules. Considering the module implemented by a class, we can have an abstraction of the system done in an interface. But if we want to extend our application adding another module that contains only some of the submodules of the original system, we are forced to implement the full interface and to write some dummy methods. Such an interface is named fat interface or polluted interface. Having an interface pollution is not a good solution and might induce inappropriate behavior in the system. -->

**接口隔离原则**规定，客户不端应该被强迫来实现它们不使用的接口。基于一组方法，许多小型接口代替了一个臃肿接口，每个接口服务一个子模块。
<!-- The **Interface Segregation Principle** states that clients should not be forced to implement interfaces they don't use. Instead of one fat interface many small interfaces are preferred based on groups of methods, each one serving one submodule. -->

## 意图 ##
<!-- ## Intent ## -->

不应强迫客户端依赖于不使用的接口。
<!-- Clients should not be forced to depend upon interfaces that they don't use. -->

## 例子 ##
<!-- ## Example ## -->

下面是违反接口隔离原则的示例。我们有一个Manager类，代表管理工人的人。我们有两种类型的工人，即普通工人和高效工人。两种类型的工人都在工作，他们每天需要休息一下才能吃饭。但是现在有些机器人也进入了公司，它们也可以正常工作，但是它们不吃东西，因此不需要发射中断。一方面，新的Robot类需要实现IWorker接口，因为机器人可以工作。另一方面，不必执行它，因为他们不吃东西。
<!-- Below is an example which violates the Interface Segregation Principle. We have a Manager class which represent the person which manages the workers. And we have 2 types of workers some average and some very efficient workers. Both types of workers works and they need a daily launch break to eat. But now some robots came in the company they work as well , but they don't eat so they don't need a launch break. One on side the new Robot class need to implement the IWorker interface because robots works. On the other side, the don't have to implement it because they don't eat. -->

这就是在这种情况下将IWorker视为受污染接口的原因。
<!-- This is why in this case the IWorker is considered a polluted interface. -->

如果我们保留当前的设计，则新的Robot类将被强制实现eat方法。我们可以编写一个不执行任何操作的虚拟类（假设每天的启动时间为1秒），并且会对应用程序产生不良影响（例如，管理人员看到的报告将报告所吃的午餐多于人数）。
<!-- If we keep the present design, the new Robot class is forced to implement the eat method. We can write a dummy class which does nothing(let's say a launch break of 1 second daily), and can have undesired effects in the application(For example the reports seen by managers will report more lunches taken than the number of people). -->

根据接口隔离原理，灵活的设计不会污染接口。在我们的情况下，应该将IWorker接口拆分为2个不同的接口。
<!-- According to the Interface Segregation Principle, a flexible design will not have polluted interfaces. In our case the IWorker interface should be split in 2 different interfaces. -->

```java
// 接口隔离原则-错误的示例
// interface segregation principle - bad example
interface IWorker {
	public void work();
	public void eat();
}

class Worker implements IWorker{
	public void work() {
		// ....working
	}
	public void eat() {
		// ...... eating in launch break
	}
}

class SuperWorker implements IWorker{
	public void work() {
		//.... working much more
	}

	public void eat() {
		//.... eating in launch break
	}
}

class Manager {
	IWorker worker;

	public void setWorker(IWorker w) {
		worker=w;
	}

	public void manage() {
		worker.work();
	}
}
```

接下来是支持接口隔离原理的代码。通过将IWorker接口拆分为2个不同的接口，不再需要新的Robot类来实现eat方法。同样，如果我们需要机器人的其他功能（如充电），则可以使用方法充电创建另一个接口IRechargeble。
<!-- Following it's the code supporting the Interface Segregation Principle. By splitting the IWorker interface in 2 different interfaces the new Robot class is no longer forced to implement the eat method. Also if we need another functionality for the robot like recharging we create another interface IRechargeble with a method recharge. -->

```java
// 接口隔离原则-很好的示例
// interface segregation principle - good example
interface IWorker extends Feedable, Workable {
}

interface IWorkable {
	public void work();
}

interface IFeedable{
	public void eat();
}

class Worker implements IWorkable, IFeedable{
	public void work() {
		// ....working
	}

	public void eat() {
		//.... eating in launch break
	}
}

class Robot implements IWorkable{
	public void work() {
		// ....working
	}
}

class SuperWorker implements IWorkable, IFeedable{
	public void work() {
		//.... working much more
	}

	public void eat() {
		//.... eating in launch break
	}
}

class Manager {
	Workable worker;

	public void setWorker(Workable w) {
		worker=w;
	}

	public void manage() {
		worker.work();
	}
}
```

## 结论 ##
<!-- ## Conclusion ## -->

如果设计已经完成，则可以使用适配器隔离臃肿接口。
<!-- If the design is already done fat interfaces can be segregated using the Adapter pattern. -->

像每个原则一样，接口隔离原则是一项原则，需要花费更多的时间和精力才能在设计期间应用它，并增加代码的复杂性。但是它产生了灵活的设计。如果我们将超出要求的范围进行应用，则会导致代码包含具有多个接口的单一方法，因此应基于经验和常识，在未来更确定容易发生代码扩展的区域进行应用。
<!-- Like every principle Interface Segregation Principle is one principle which require additional time and effort spent to apply it during the design time and increase the complexity of code. But it produce a flexible design. If we are going to apply it more than is necessary it will result a code containing a lot of interfaces with single methods, so applying should be done based on experience and common sense in identifying the areas where extension of code are more likely to happens in the future. -->
