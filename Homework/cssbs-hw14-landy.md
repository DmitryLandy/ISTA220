## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 14
## DATE: 2/24/2021
---
**1. What is the difference between a managed resource and an unmanaged resource?**

- Unmanaged: not under the control of the CLR
- Managed: 

**2. When is memory for an object (reference type) allocated? When is the memory deallocated?**

- "New" keyword allocates
- When the object is no longer in scope and a destructor is used.

**3. What is a destructor?**

- an object that performs garbage collection

**4. What is the difference in syntax between a constructor and a destructor?**

- Destructors have a tilde (~) followed by the class name

**5. Give some examples of scarce resources. Why would you want to manage scarce resources?**

- memory, db connections, file handlers
- Because they are scarce and can critically affect the program

**6. What is exception-safe disposal?**

- putting the disposal method in the finally block of a try catch

**7. How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.**

- The variable only lives as long as it is within the scope of the using statement.

**8. What ill effects could result from attempting to dispose of a resource more than once?**

- exceptions 

**9. We will look at threads later in the term. For now, what is your understanding of how threads interact with resource management? A good guess is a siufficient answer to this question.**

- sub-procedures of a process

**10. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions to this recommendation?**

- you can impair the performance of the application. 
- It can cause you to lose data.

