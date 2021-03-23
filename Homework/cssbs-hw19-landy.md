## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 19
## DATE: 3/22/2021
---
**1. What is an enumerable collection?**
- Something that implements IEnumerable. Used to step through the elements in the collection.

**2. What properties and methods does the IEnumerable interface contain?**
- 1 Method: GetEnumerator()

**3. What properties and methods does the IEnumerator interface contain?**
- Current
- MoveNext()
- Reset()

**4. What values does the MoveNext() method return? What does it do?**
- Boolean. Moves the pointer through the collection

**5. What values does the Reset() method return? What does it do?**
- Void. Move pointer back to before the first item

**6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?**
- Only when using the generic interfaces

**7. Why don't recursive methods retain state when used with data structures like binary trees?**
- They don't retain data between method calls

**8. How do you define an enumerator?**
- you have to inherit from the Interface and then you have to define the methods and properties

**9. What is an iterator?**
- block of code that yields an ordered sequence of values. 

**10. What does yield do?**
- It delays the return of the values until all the data is collected.