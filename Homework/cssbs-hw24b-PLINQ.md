## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 24a
## DATE: 4/25/2021
---
1. What are the two scenarios in which you can use PLINQ to speed up operations? Why does using PLINQ in these scenarios speed up processing?
- Searching through a lengthy data structure
- matching complex, computationally expensive operations
- It partitions the data

2. How does AsParallel qualify as an extension method? First, explain what an extension method is and
how you define entension methods, and them explain why AsParallel qualifies as an extension method.
- It returns a parallel query object
- It extends LINQ (Such as Join and where)

3. How do you cancel a PLINQ query before it finishes? Be specific with respect to the variables and
methods used for the cancellation operation, and how the variables abd methods are used.
- Create cancellation token
- use withCancellation extension method
- generates OperationCanceledException when token is used

4. Why is it important to synchronize concurrent access to a server? Give an example of a specific
condition that will cause an error in your application if concurrent access is not synchronized.
- To avoid corruption of data as two tasks can be modifying data at the same time without synchronization

5. What does the lock statement do?
- attempts to obtain a mutual exlusion lock over an object
- if the object is locked by another threat, the object is blocked.

6. This is not in the book. Define mutex, define semaphore, and explain the difference between them.
- mutual exclusion object
- synchronization primitive 
- allows threads to share a resource

- semaphores limit the number of threads that can access a resource or resource pool concurrently

7. What does it mean to say that some collection classes are not thread safe? Explain how not being
thread safe may lead one of these collection classes to produce a malfunction in the program.
- thread safe object is protected from multiple simulaneous execution  by mutex
- Non thread safe code could have resources that are altered by mutual threads resulting in unintented results

8. Explain how thread safe collection classes are made thread safe.
9. Why are thread safe classes slower than non-thread safe classes? Be specific.