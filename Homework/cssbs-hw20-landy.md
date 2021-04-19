## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 20
## DATE: 3/28/2021
---
**1. What is a delegate? Explain delegates in terms of pointers and reference types.**
- delegates are types
- reference to a method
- they point to the method 
- Method is assigned to a delegate reference

**2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.**
- delegate void <name> ().
- no parameters, no return types

**3. How do you create instances of delegates and assign values to the instance? What are the values?**
- Use the "new" keword or +=
- you pass a method to the instance or += it to the instance

**4. How do you invoke a method that has been added to a delegate?**
- Using the delegate instance name

**5. What is an event? Why do we have events?**
- Something happening in the environment
- Events are executions of methods via delegates
- organize actions for delegates to handle

**6. How do you declare events?**
- In the event source class
- event <delegateTypeName> <eventName>

**7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?**
- sub by using the += operator
- unsub by using the -= operator

**8. How do you raise an event? How do you declare code that raises an event?**
- Calling the event like a method
- In the body, perform a null check before calling the methods

**9. Explain with specificity what happens when an event fires and that event has been attached to a delegate.**
- All the methods start executing serially
