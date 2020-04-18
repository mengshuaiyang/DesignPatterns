*[设计原则](document/design-principles.md)*
------
- [ ] [开闭原则](document/open-close-principle.md)
- [x] [依赖性倒置原则](document/dependency-inversion-principle.md)
- [x] [接口隔离原则](document/interface-segregation-principle.md)
- [x] [单一职责原则](document/single-responsibility-principle.md)
- [x] [里氏替换原则](document/liskov-s-substitution-principle.md)

*创建型模式*
------
- [x] [单例模式](document/singleton-pattern.md)
- [x] [工厂模式](document/factory-pattern.md)
- [x] [工厂方法模式](document/factory-method-pattern.md)
- [x] [抽象工厂模式](document/abstract-factory-pattern.md)
- [ ] [建造者模式](document/builder-pattern.md)
- [x] [原型模式](document/prototype-pattern.md)
- [ ] [Object Pool](document/object-pool-pattern.md)

*行为模式*
------
- [ ] [Chain of Responsibility](document/chain-of-responsibility-pattern.md)
- [ ] [Command](document/command-pattern.md)
- [ ] [Interpreter](document/interpreter-pattern.md)
- [ ] [Iterator](document/iterator-pattern.md)
- [ ] [Mediator](document/mediator-pattern.md)
- [ ] [Memento](document/memento-pattern.md)
- [ ] [Observer](document/observer-pattern.md)
- [ ] [Strategy](document/strategy-pattern.md)
- [ ] [模版方法](document/template-method-pattern.md)
- [ ] [Visitor](document/visitor-pattern.md)
- [ ] [Null Object](document/null-object-pattern)

*[结构模式](document/structural-patterns.md)*
------
- [x] [适配器模式](document/adapter-pattern.md)
- [x] [桥接模式](document/bridge-pattern.md)
- [ ] [Composite](document/composite-pattern.md)
- [ ] [Decorator](document/decorator-pattern.md)
- [ ] [Flyweight](document/flyweight-pattern.md)
- [ ] [Proxy](document/proxy-pattern.md)

# [设计模式](http://www.oodesign.com/) #

软件设计需满足SOLID软件设计原则

S.O.L.I.D.是一组面对面向对象设计的最佳实践的设计原则。代表下面的设计原则：

## 单一职责原则(Single Responsibility Principle，SRP) ##

有且仅有一个原因引起类的变更。接口一定要做到单一职责，类的设计尽量做到只有一个原因引起变化。

## 开闭原则(Open Closed Principle) ##

软件实体应该对扩展开放，对修改关闭

## 里氏替换原则（Liskov Substitution Principle，LSP） ##

* 子类必须完全实现父类的方法
* 子类可以有自己的个性
* 覆盖或实现父类的方法时输入参数可以被放大
* 覆写或实现父类的方法时输出结果可以被缩小

## 迪米特法则(Law of Demeter) ##

迪米特法则的核心观念就是类间解耦，弱耦合，只有弱耦合了以后，类的复用率才可以提高。

* 一个对象应该对其他对象有最少的了解。
* 迪米特法则要求类“羞涩”一点，尽量不要对外公布太多的public方法和非静态的public变量，尽量内敛，多使用private、package-private、protected等访问权限。
* 是自己的就是自己的：如果一个方法放在本类中，既不增加类间关系，也对本类不产生负面影响，那就放置在本类中。

## 接口隔离原则(Interface Segregation Principle，ISP) ##

* 接口要尽量小
* 接口要高内聚
* 定制服务
* 接口设计是有限度的

## 依赖倒置原则(Dependence Inversion Principle，DIP) ##

* 构造函数传递依赖对象
* Setter方法传递依赖对象
* 接口声明依赖对象

---

# 设计模式 #

## 设计模式分为三类：创建型(Creational)、结构型(Structural)、行为型(Behavioral) ##

创建型模式与对象的创建有关，

创建型设计模式：工厂方法模式(Factory Method Pattern)、抽象工厂模式(Abstract Factory Pattern)、单例模式(Singleton Pattern)、生成器模式(Builder Pattern)、原型模式(Prototype Pattern)

结构型模式处理类或对象的组合

结构型设计模式：适配器(Adapter)、桥接(Bridge)、组合(Composite)、装饰(Decorator)、外观(Facade)、享元(Flyweight)、代理(Proxy)

行为型模式对类或对象怎样交互和怎样分配职责进行描述

行为型设计模式：职责链(Chain of Responsibility)、命令(Command)、解释器(Interpreter)、迭代器(Iterator)、中介者(Mediator)、备忘录(Memento)、观察者(Observer)、状态(State)、策略(Strategy)、模版方法(Template method)、访问者(Visitor)

---

抽象类(abstract class)主要目的是为它的子类定义公共接口

在抽象类中定义却没有实现的操作被称为抽象操作(abstract operation)

非抽象类称为具体类(concrete class)

混入类(mixin class)是给其他类提供可选择的接口或功能的类，与抽象类一样不能实例化





