## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 11 HW
## DATE: 2/18/2021
---
**1. What is a parameter array?**

- parameters that take any number of arguments of any type

**2. How do you define a method that takes an arbitrary number of arguments?**
```
public static void methodName (params object[] paramList)
```
**3. How do you call a method that takes an arbitrary number of argiments?**

- methodname("bob", 42, array);

**4. Why can’t you use an array to pass an arbitrary number of arguments to a method?**

- Because arrays have a defined limit.

**5. How many parameters can a method have?**

- any number

**6. Do parameter arguments have to have the same type?**

- no they don't

**7. What is the difference between a method that takes a parameter argument and one that takes optional arguments?**

- non-optional parameters must be passed, whereas optional don't.
- The more specific method is the one that executes if both are valid to be called.

**8. How do you define a method that takes different (and arbitrary) types of arguments?**
```
public static void methodName (string x, int y, object q)
```

**9. Write a method that accepts any number of arguments of a given type.**
```
public static void methodName (params int[] paramList)
```

**10. Write a method that accepts any number of arguments of any type.**
```
public static void methodName (params object[] paramList)
```