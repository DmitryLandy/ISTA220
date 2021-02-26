## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 13
## DATE: 2/23/2021
---
**1. What is an interface as the term is used on object-oriented programmoing?**

- Just non initialized properties and methods that classes inheriting from the interface must provide. 
- Separate the "what" from the "how"

**2. How do you define an interface?**

- use "interface" keyword

**3. Can an interface have variables, fields, or properties?**

- They can't be defined. 

**4. How do you define a method in an interface?**

- just provide the return type and the method name, parameters with semicolon

**5. Can you instantiate an object through an interface? Why or why not?**

- Yes. because objects can implement interfaces.

**6. Using the new keyword, can you declare a reference to an interface?**

- no because an interface can't have an implementation of the interface. It must be a concrete class. 

**7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how can it do so?**

- Yes they can implement multiple interfaces and inherit from multiple
- class Horse: Interface1, Interface2
- Just implement the method as would normally.

**8. What does it mean to explicitely implement an interface?**

- To explicitly state where the method is coming from.
- <interface Name>.<method()>

**9. What are the restrictions on interfaces?**

- No defined field not even static
- no constructors/destructors
- no specific modifier
- no enums, structs, classes, interfaces nested within
- can't inherit.

**10. What is the difference between an abstract class and an interface?**

- Interfaces MUST be implemented. Can't contain implementation.
- Abstract classes don't have to.

**11. What is an abstract method?**

- a virtual method without a method body.
- Derivitive class MUST override it

**12. What is an sealed class?**

- Prevents a class from being used as a base class
- can't be inherited.

**13. What is an sealed method?**

- Derived class can't override the method. 
- It's considered the last implementation of a method.

