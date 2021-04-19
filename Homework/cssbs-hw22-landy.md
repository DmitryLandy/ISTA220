## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 22
## DATE: 4/12/2021
---
**1. Explain the difference between the concepts of associativity and precedence.**

- precedence is the order of execution
- how it evaluates (left to right or right to left)

**2. Explain the difference between the concepts of binary and unary operators.**

- unary is increment decriment (take one operand ie: thisVar++)
- binary is the operator (takes two operands ie: a + b)

**3. List four constraints imposed by C# with respect to operator overloading.**

- must be public
- must be static 
- can't be polymorphic
- must have two arguments and use a unary operator

**4. What is the syntax for overloading operators? Discuss access, scope, return value types, and parameter types and multiplicity.**

- public static <Name> operator +( a, b) => new type(a.value + b.value);

**5. What are symmetric overloaded binary operators and how do they differ from non-symmetric overloaded binary operators?**

- They are operators that can perform an operation on two different types. Non-symmetric perform on the same types

**6. Can you overload compound assignment operators? If so, please state how you do so. If not, explain why not.**

- it can't because the syntax is always evaluated the same way

**7. What is the difference between overloading increment and decrement operators for value types and reference types?**

- Classes require the New keyword when using the increment operator in the definition as it needs to create a new reference

**8. Why do we overload some operators in pairs?**

- because they are natural pairs and logically work inverse of each other (ie != and ==)

**9. What is the difference between widening conversion and narrowing conversion?**
- widening conversion results in a type that can be more specific (int to double)
- narrowing conversion results in a type that is less specific (double to int)

**10. What is the difference between explicit conversion and implicit conversion?**

- explicit requires a cast
- implicit can be assigned directly