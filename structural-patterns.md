Structural Patterns
Adapter Pattern
Adapter Pattern
Intent
Convert the interface of a class into another interface clients expect.
Adapter lets classes work together, that could not otherwise because of incompatible interfaces.

Implementation
Adapter  Pattern Implementation - UML Class Diagram 

The classes/objects participating in adapter pattern:
Target - defines the domain-specific interface that Client uses.
Adapter - adapts the interface Adaptee to the Target interface.
Adaptee - defines an existing interface that needs adapting.
Client - collaborates with objects conforming to the Target interface.
Read more...
 
Flyweight Pattern
Flyweight Pattern
Intent
The intent of this pattern is to use sharing to support a large number of objects that have part of their internal state in common where the other part of state can vary.
Implementation
The figure below shows a UML class diagram for the Flyweight Pattern:
Flyweight Pattern Implementation - UML Class Diagram 
Flyweight - Declares an interface through which flyweights can receive and act on extrinsic state.
ConcreteFlyweight - Implements the Flyweight interface and stores intrinsic state. A ConcreteFlyweight object must be sharable. The Concrete flyweight object must maintain state that it is intrinsic to it, and must be able to manipulate state that is extrinsic.
FlyweightFactory - The factory creates and manages flyweight objects. In addition the factory ensures sharing of the flyweight objects. The factory maintains a pool of different flyweight objects and returns an object from the pool if it is already created, adds one to the pool and returns it in case it is new.
Client - A client maintains references to flyweights in addition to computing and maintaining extrinsic state
Read more...
 
Decorator Pattern
Extending an object�s functionality can be done statically (at compile time) by using inheritance however it might be necessary to extend an object�s functionality dynamically (at runtime) as an object is used.

Consider the typical example of a graphical window. To extend the functionality of the graphical window for example by adding a frame to the window, would require extending the window class to create a FramedWindow class. To create a framed window it is necessary to create an object of the FramedWindow class. However it would be impossible to start with a plain window and to extend its functionality at runtime to become a framed window.

Decorator Pattern Implementation - UML Class Diagram
Read more...
 
Composite Pattern
There are times when a program needs to manipulate a tree data structure and it is necessary to treat both Branches as well as Leaf Nodes uniformly. Consider for example a program that manipulates a file system. A file system is a tree structure that contains Branches which are Folders as well as Leaf nodes which are Files. Note that a folder object usually contains one or more file or folder objects and thus is a complex object where a file is a simple object. Note also that since files and folders have many operations and attributes in common, such as moving and copying a file or a folder, listing file or folder attributes such as file name and size, it would be easier and more convenient to treat both file and folder objects uniformly by defining a File System Resource Interface.



Intent
The intent of this pattern is to compose objects into tree structures to represent part-whole hierarchies.
Composite lets clients treat individual objects and compositions of objects uniformly.

Implementation
The figure below shows a UML class diagram for the Composite Pattern:
Composite Pattern Implementation - UML Class Diagram 

Read more...
 
Bridge Pattern
Bridge Pattern
Intent
The intent of this pattern is to decouple abstraction from implementation so that the two can vary independently.

Implementation
The figure below shows a UML class diagram for the Bridge Pattern:
Bridge Pattern Implementation - UML Class Diagram 
The participants classes in the bridge pattern are:
Abstraction - Abstraction defines abstraction interface.
AbstractionImpl - Implements the abstraction interface using a reference to an object of type Implementor.
Implementor - Implementor defines the interface for implementation classes. This interface does not need to correspond directly to abstraction interface and can be very different. Abstraction imp provides an implementation in terms of operations provided by Implementor interface.
ConcreteImplementor1, ConcreteImplementor2 - Implements the Implementor interface.
Read more...
 
Proxy Pattern
Sometimes we need the ability to control the access to an object. For example if we need to use only a few methods of some costly objects we'll initialize those objects when we need them entirely. Until that point we can use some light objects exposing the same interface as the heavy objects. These light objects are called proxies and they will instantiate those heavy objects when they are really need and by then we'll use some light objects instead.

This ability to control the access to an object can be required for a variety of reasons: controlling when a costly object needs to be instantiated and initialized, giving different access rights to an object, as well as providing a sophisticated means of accessing and referencing objects running in other processes, on other machines.

Consider for example an image viewer program. An image viewer program must be able to list and display high resolution photo objects that are in a folder, but how often do someone open a folder and view all the images inside. Sometimes you will be looking for a particular photo, sometimes you will only want to see an image name. The image viewer must be able to list all photo objects, but the photo objects must not be loaded into memory until they are required to be rendered.

Proxy Pattern Virtual Proxy Example - UML Class Diagram 
The intent of the proxy pattern is to provide a �Placeholder� for an object to control references to it.

Read more...