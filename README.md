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

## 设计模式分为三类：创建型、结构性、行为型 ##

创建型设计模式都涉及到创建对象实例的方式

创建型设计模式：工厂方法模式(Factory Method Pattern)、抽象工厂模式(Abstract Factory Pattern)、单例模式(Singleton Pattern)、生成器模式(Builder Pattern)、原型模式(Prototype Pattern)



