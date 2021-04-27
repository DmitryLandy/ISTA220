## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 24a
## DATE: 4/25/2021
---
**1. What is an asynchronous method? When the book talks about a contract, what is the contract and who is it with?**
- it does not block the current thread that it runs on.
- A contract is a condition that is implied in which the method returns control to the calling environment quickly.

**2. What can be the problem with decomposing a series of discrete method calls into a set of tasks, such as we saw in chapter 23?**
- Tasks present the problem of using Wait, which blocks certain threads.

**3. What can be the problem with decomposing a series of discrete method calls into a set of continuations? When does the last continuation “complete” as compared to the previous continuations? What problem might this cause?**
- It completes when the last method runs, even if it runs earlier.

**4. What might be the problem with implementing te previous solution as a continuation passing a delegate? What would be your interpretation with this error message: “The application called an interface that was marshaled for a different thread.”?**
- Only the user interface thread can manipulate user interface controls, which means the output requires another thread.

**5. The book suggests a solution using a continuation delegate calling another continuation delegate via an anonymous function. What does the book ientify as a problem with this suggested solution?**
- Just use "await" for each method with an "async" method

**6. What does the async modifier do? What does the await operator do?**
- async indicates he method contains functionality that can run async. Can be divided into multiple continuations.
- await specifies the function should be performed asynchronously. It becomes an awaitable object.

**7. What is an awaitable object? Be specific.**
- A type that provides the GetAwaiter method (which returns provides methods to run the code and waiting for it to complete).

**8. In a method definition, how do you create and run a Task and return a reference to the Task? What is the type of such a method? What does the method return?**
- async Task

**9. How do you define method calls in the implementation of an async method? Specifically, you must define a task, you must run the task, you must implement the task, and you must await the task. What is the syntax for doing this?**
```
private async Task doFirstLongRunningOperation()
{
    Task first = Task.Run(() => { /* code for first operation */ });

    Task second = Task.Run(() => { /* code for second operation */ });

    await first;

    await second;
}
```

**10. What is the difference between decomposing a series of method calls that do not return values, and a series of method calls that return values? What is the Result property of a method that returns a value? How do you use the await operator in this circumstance?**
- The result propery is the return value of an async method.
- It only returns the value when its ready

**11. What is the difference between the await operator and the Wait method?**
- async just specifies the method can implement async, await specifies which part runs async.