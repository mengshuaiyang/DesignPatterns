# [单一职责原则](https://www.oodesign.com/single-responsibility-principle.html) #
<!-- # Single Responsibility Principle # -->

## 动机 ##
<!-- ## Motivation ## -->

单一职责原则是指只会因为一个原因修改类。该原则指出，如果有两个原因需要更改一个类，则必须将功能分为两个类。每个类将只负责一项职责，如果将来我们需要进行一项更改，我们将对负责该职责的类进行更改。当我们需要对职责更多的类进行更改时，更改可能会影响与该类其他职责相关的其他功能。
<!-- In this context, a responsibility is considered to be one reason to change. This principle states that if we have 2 reasons to change for a class, we have to split the functionality in two classes. Each class will handle only one responsibility and if in the future we need to make one change we are going to make it in the class which handles it. When we need to make a change in a class having more responsibilities the change might affect the other functionality related to the other responsibility of the class. -->

**单一职责原则**是一个简单而直观的原则，但在实践中有时很难正确地做到这一点。
<!-- **The Single Responsibility Principle** is a simple and intuitive principle, but in practice it is sometimes hard to get it right. -->

## 意图 ##
<!-- ## Intent ## -->

一个类只有一个改变的理由。
<!-- A class should have only one reason to change. -->

## 例子 ##
<!-- ## Example ## -->

假设我们需要一个对象发送电子邮件。我们将使用以下示例中的IEmail接口。乍看起来，一切看起来都很好。仔细观察，我们可以看到我们的IEmail接口和Email类有2个职责（更改原因）。一种是在某些电子邮件协议（例如pop3或imap）中使用该类。如果必须支持其他协议，则应以其他方式序列化对象，并应添加代码以支持新协议。另一个将用于“内容”字段。即使内容是字符串，我们将来也可能希望支持HTML或其他格式。
<!-- Let's assume we need an object to keep an email message. We are going to use the IEmail interface from the below sample. At the first sight everything looks just fine. At a closer look we can see that our IEmail interface and Email class have 2 responsibilities (reasons to change). One would be the use of the class in some email protocols such as pop3 or imap. If other protocols must be supported the objects should be serialized in another manner and code should be added to support new protocols. Another one would be for the Content field. Even if content is a string maybe we want in the future to support HTML or other formats. -->

如果我们仅保留一个类，那么一项职责的每项变更都可能影响另一类：
<!-- If we keep only one class, each change for a responsibility might affect the other one: -->

> * 添加新协议将需要添加用于解析和序列化每种字段类型内容的代码。
> * 添加新的内容类型（如html）使我们可以为实现的每个协议添加代码。
<!--  * Adding a new protocol will create the need to add code for parsing and serializing the content for each type of field. -->
<!--  * Adding a new content type (like html) make us to add code for each protocol implemented. -->

```java
// 单一责任原则-错误的示例
// single responsibility principle - bad example

interface IEmail {
	public void setSender(String sender);
	public void setReceiver(String receiver);
	public void setContent(String content);
}

class Email implements IEmail {
	public void setSender(String sender) {// set sender; }
	public void setReceiver(String receiver) {// set receiver; }
	public void setContent(String content) {// set content; }
}
```

我们可以创建一个名为IContent和Content的新接口和类来划分职责。每个类只负责一项，可以使我们的设计更加灵活：
<!-- We can create a new interface and class called IContent and Content to split the responsibilities. Having only one responsibility for each class give us a more flexible design: -->

> * 添加新协议只会导致在Email类中进行更改。
> * 添加受支持的新型内容只会导致Content类中的更改。

<!-- > * adding a new protocol causes changes only in the Email class.
> * adding a new type of content supported causes changes only in Content class.-->
 
```java
// 单一责任原则-很好的示例
// single responsibility principle - good example
interface IEmail {
	public void setSender(String sender);
	public void setReceiver(String receiver);
	public void setContent(IContent content);
}

interface Content {
	public String getAsString(); // used for serialization
}

class Email implements IEmail {
	public void setSender(String sender) {// set sender; }
	public void setReceiver(String receiver) {// set receiver; }
	public void setContent(IContent content) {// set content; }
}
```

## 结论 ##
<!-- ## Conclusion ## -->

单一职责原则是在应用程序的设计阶段识别类的好方法，它提醒您考虑类可以演化的所有方式。只有在充分了解应用程序应如何工作的全貌之后，才能很好地划分职责。
<!-- The Single Responsibility Principle represents a good way of identifying classes during the design phase of an application and it reminds you to think of all the ways a class can evolve. A good separation of responsibilities is done only when the full picture of how the application should work is well understand. -->
