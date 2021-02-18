## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 12 HW
## DATE: 2/17/2021
---
**1. How does inheritance promote the principle of don’t repeat yourself (DRY)?**

- Inheritence allows a  base class to pass down variables and methods so that the class that inherits it doesn't have to re-write the info

**2. What is the syntax of a derived class that inherits from a base class?**
```
class DerivedClass : BaseClass { }
```
**3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?**

- The System.Object class

**4. What happens if you do not have a default constructor in a base class when creating a derived class?**

- the default constructed from the base class will be called

**5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?**

- yes, but it will lose some functionality of the derived class that isn't in the base class

**6. Can you assign a variable of a derived class to another variable of a derived class of its base class? Why or why not?**

- No because they are different classes

**7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?**

- Only with a cast, but cause a run-time error so no.

**8. Under what circumstances would you want to use the new keyword when defining a method in a derived class?**

- To turn off the warning. If you want a derived class (son) of a derived class (Father) to use the derived class's (father) method instead of the base class's (grandpa) method.

**9. What is a virtual method? Why would you want to define a virtual method?**

- A method that is intended to be overridden, like the toString().

**10. What does override do? Why does it do it?**

- Override keyword states that the current instance of that method will perform differently than the original method. The change only applies to that instance though.

**11. How do you define an extension type?**

- in a static class, use ```this``` keyword in the first parameter

**12. Why do you define an extension type?**

- To quickly extend the functionality of an object without changing the code.

**13. (Not in book) Explain the Liskov substitution principle.**

- *" functions that use references to base classes must be able to use objects of the derived class without knowing it. "*
- derived classes must be substitutable for the base class.