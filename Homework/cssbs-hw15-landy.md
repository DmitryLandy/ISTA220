## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 15
## DATE: 2/24/2021
---
**1. What is the difference between a property and a field?**

- Property: looks like a field, acts like a method. They expose fields
- Field: A usually private variable within the class

**2. What is the difference between a property and a method?**

- Properties target fields specifically via get/set

**3. What is your understanding of encapsulation?**

- Its the access control within the program

**4. Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods,and other identifiers? Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them?**

- It causes the same word to do different things based on its case.
- Difficult to debug.

**5. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use s write-only property.**

- Read-Only: Only get. for output
- Write-Only: Only set. for input. Logging, password

**6. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.**

- no reason. Private means only the class can use it, which defeats the purpose of the property

**7. What are restrictions on the use of properties?**

- Can be used after initialization
- can't use ref or out. Points to an accessor method
- only one set and get accessor
- get set can't have parameters
- can't be const.

**8. What is an object initializer? What is the syntax for an object initializer?**

- Constructor that calls and initializes the fields via the properies.
- Uses {} instead of ()
