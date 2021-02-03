#### NAME: Dmitry Landy 
#### ASSIGNMENT: C# Chapter 7 Homework 
#### DATE: 2/2/2020
---
**1. What is a class? According to the book, what does a class “arrange?”**
- A type
- named body containing related sets of methods and data items
- arranges data and methods.

**2. What are the two purposes of encapsulation?**

- combine methods and data within a class (support classification) 
- control accessibility

**3. How do you instantiate an instance of a class? How do you access that instance?**

- Using the "New" keyword.
- Call it by its instance name

**4. What is the default access of the fields and methods of a class? How do you change the default?**

- private is the default
- explicitly declare it (e.g. public)

**5. What is the syntax for writing a constructor?**
- a method that uses the same name as the class.
- no return type.

**6. What is the difference between class fields and methods, and instance fields ad methods? How do you create class fields and methods?**
- one is declared and created within the class (class) and defined with static
- and the other simply refernces them (instance). Can only be accessed by the object of that class.

- declare them inside the class scope.

**7. How do you bring a static class in scope? Why would you want to bring a static class in scope?**

- static *using* statments bring it in scope
- to access the static methods of that class

**8. Can you think of a good reason to create an anonymous class? What is it?**

- declare and instantiate a class at the same time
- if you don't know the type of the object yet.

**9. What is polymorphism as this term is used in computer science? This is not in the book.**

- Ability for an object to take multiple variations of the object;

**10. What is message passing as this term is used in computer science? This is not in the book.**

- How OOP operate. The caller tells the call method to do something without worrying about the execution of the action.

**11. What was the first object-oriented programming language?**

- Simula 67

**12. Consider this quote by Alexander Stepanov:
```
I find OOP technically unsound. It attempts to decompose the world in terms of interfaces
that vary on a single type. To deal with the real problems you need multisorted algebras
— families of interfaces that span multiple types. I find OOP philosophically unsound. It
claims that everything is an object. Even if it is true it is not very interesting — saying that
everything is an object is saying nothing at all.```

**Who is Alexander Stephanov? What do you think about this quote?**

- Russian programmer advocate of generic programming. 
- If everything is an object, then things are no different from one another. They are all the same in a sense.