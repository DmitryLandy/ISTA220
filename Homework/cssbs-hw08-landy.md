#### NAME: Dmitry Landy 
#### ASSIGNMENT: C# Chapter 8 Homework 
#### DATE: 2/3/2020
---
**1. What is the difference between deep copy and shallow copy?**
- Deep Copy: 
	- Contains a copy of the data (value types)
	- Copies the true data (up to the heap if necessary)
- Shallow copy: 
	- contains copy of the reference (reference types)
	- Copies just what is on the stack.

**2. What is the value of a reference after you declare and initialize it?**

- Its the memory location of the actual data.

**3. How do you declare a value type?**

- By specifying the class name of data types that fall under "value type"
- int, byte, float, char
- value types store the data directly

**4. How do you declare a reference type?**

- By specifying the class name of the data type that fall under "reference type"
- String, custom classes, anything without a defined memory space

**5. Does C# allow you to assign NULL to a value type?**

- Yes by using the '?' operator to indicate the value type is nullable ONLY if it is being declared. After declared as a non-null, then no.
- int? i = null;

**6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?**

- No, because the memory space for that value type has already been assigned.

**7. What is the difference between the stack and the heap?**

- Stack: data has a defined lifespan. For data in methods, the are added to the stack when the method starts, and leave when the method ends.

- Heap: Objects created by using "new" keyword. The memory is allocated when the first reference is created. The memory is deleted when the last reference is deleted.

**8. What does it mean when we say that all classes are specialized types?**

- System.Object class come from the System namespace. This can be used to create a variable that can refere to any reference types.

- Encapsulate properties and behavior of an object.

**9. What does ref do?**

- Allows you to modify the argument (which is just a reference)
- ref specifies pass-by-reference.
- Prefixing the parameter with 'ref' will allow the compiler to generate code to the actual argument instead of just the copy of that argument.
- Updates the reference.

**10. What does out do?**

- allows the argument to be initialized by the body of the method and only the method.

**11. Describe boxing and unboxing in your own words.**

- Boxing: copying an item from the stack to the heap to allow "direct" access of a reference type to a value type.

- Unboxing: Boxed value assigned to int.

**12. What does cast do?**

- temporarily converts of a data type into a different data type by copying the data.

