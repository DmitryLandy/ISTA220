#### NAME: Dmitry Landy 
#### ASSIGNMENT: C# Chapter 6 Homework 
#### DATE: 1/27/2020
---
**1. What is an exception?**

- error alert in the code that prevents further execution of that code.

**2. What happens in a try block if the program executes without errors?**

- The program executes as normal until the end of the block

**3. How does the catch mechanism work for unhandled exceptions?**

- The program will throw an exception and will attempt to find the appropriate catch handle, even if its outside the block. If there isn't one, the program will terminate.

**4. What happens in a program if an exception block fails to handle a particular error**

- The program will attempt to find the generic exception handler. If there isn't one it will terminate

** 5. What is the parent class for all exceptions? How does this work?**

- Exception Class
- Stores all different types of exceptions for C#
- Specific exceptions inherit from this class

**6. How do you determine the type of an error?**

- The message property of the exeption

**7. What is the purpose of integer checking?**

- to alert the user of OverflowException errors using the ```checked``` and ```unchecked``` keywords

**8. What is the range of values that a signed Int32 type can contain? State the lowest value and the highest value.**

- negative 2,147,483,648 through positive 2,147,483,647
- ```int.minValue(int)``` and ```int.maxValue(int)```

**9. What is the range of values that an unsigned Int32 type can contain? State the lowest value and the highest value. What is the difference between a signed integer and an unsigned integer? Can signed integers and unsigned integers represent the same amount of numbers?**

- 0 to 4,294,967,295.
- Same number of integers, but they are all positive.

**10. What does the finally block do?**

- ensures code always runs even after an exception occurred.

**11. (Thought question) When would you not use a finally block in a try/catch construction?**

- If you know the catch will work
- When you want the code to terminate due to the error
