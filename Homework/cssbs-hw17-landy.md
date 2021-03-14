## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 17
## DATE: 3/10/2021
---
**1. What is a type parameter?**
- Parameters within "<>" 

**2. What does a type parameter do?**
- They specify what type the object needs.

**3. How many type parameters can a generic class have?**
- Multiple. No limit

**4. What is the difference between a generic class and a generalized class?**
- A Generic class has type parameters
- Generalized class has object parameters that are later casted to a type within the class

**5. What is a constraint? How do you specify a constraint?**
- A constraint limits the type parameter. 
- <T> where T: someType

**6. What is a generic method? How do you define a generic method?**
- A method that has type parameters and uses the type within the body of the method
- add the type parameter after the method name
- Use "ref" keyword to reference the type parameter in the parameters list

**7. What do we mean when we say that a generic type interface is invariant?**
-  Only use the originally specified type (not more or less derived).

**8. What do we mean when we say that a generic type interface is covariant?**
- Use the more derived type

**9. Does covariance work with value types? Does it work with reference types?**
- Just with reference types.

**10. What do we mean when we say that a generic type interface is contravariant?**
- Use less derived type (more generic) than the original