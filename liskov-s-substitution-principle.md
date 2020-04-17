# [里氏替换原则(LSP)](https://www.oodesign.com/liskov-s-substitution-principle.html) #
<!-- # Liskov's Substitution Principle(LSP) # -->

## 动机 ##
<!-- ## Motivation ## -->

一直以来，我们都设计一个程序模块，并创建一些类层次结构。然后我们扩展一些类，创建一些派生类。
<!-- All the time we design a program module and we create some class hierarchies. Then we extend some classes creating some derived classes. -->

我们必须确保新的派生类可以扩展而不替换旧类的功能。否则，当新类在现有程序模块中使用时，可能会产生不希望的效果。
<!-- We must make sure that the new derived classes just extend without replacing the functionality of old classes. Otherwise the new classes can produce undesired effects when they are used in existing program modules. -->

里氏替换原则指如果程序模块使用基类，则可以用派生类替换对基类的引用，而不会影响程序模块的功能。
<!-- Likov's Substitution Principle states that if a program module is using a Base class, then the reference to the Base class can be replaced with a Derived class without affecting the functionality of the program module. -->

## 意图 ##
<!-- ## Intent ## -->

派生类型必须完全可以替换为其基本类型。
<!-- Derived types must be completely substitutable for their base types. -->

## 例子 ##
<!-- ## Example ## -->

以下是违反里氏替换原则的经典示例。在示例中，使用了2个类：矩形和正方形。假设Rectangle对象在应用程序中的某处使用。我们扩展应用程序并添加Square类。根据某些条件，正方形类是通过工厂模式返回的，我们不知道将返回哪种类型的对象。但是我们知道这是一个矩形。我们得到矩形对象，将宽度设置为5，将高度设置为10，并获得面积。对于宽度为5，高度为10的矩形，面积应为50。取而代之的是100
<!-- Below is the classic example for which the Likov's Substitution Principle is violated. In the example 2 classes are used: Rectangle and Square. Let's assume that the Rectangle object is used somewhere in the application. We extend the application and add the Square class. The square class is returned by a factory pattern, based on some conditions and we don't know the exact what type of object will be returned. But we know it's a Rectangle. We get the rectangle object, set the width to 5 and height to 10 and get the area. For a rectangle with width 5 and height 10 the area should be 50. Instead the result will be 100 -->

```java
// 违反里氏替换原则
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

## 结论 ##
<!-- ## Conclusion ## -->

该原理只是“打开关闭原理”的扩展，它意味着我们必须确保新的派生类在不改变其行为的情况下扩展了基类。
<!-- This principle is just an extension of the Open Close Principle and it means that we must make sure that new derived classes are extending the base classes without changing their behavior. -->