## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 23
## DATE: 4/18/2021
---
**1 List two reasons for multitasking, and explain the rationale for them.**
- To improve responsiveness - long running tasks won't hold up other tasks
- To improve scalability - effecient use of computer resource allows to support more users

**2 Explain Moore’s law. What does Moore’s law have to do with multitasking?**
- Number of transistors that can be placed inexpensively on an integrated circuit will increase exponentially, doubling approximately every two years.
- More transistors allows for more data to be passed quicker, which allows more complex code to be written

**3 In UWP, what namespace is used as the container for the multitasking methods?**
- Task namespace

**4 What is the difference between tasks and threads? Explain.**
- Tasks are abstractions of a concurrent operations
- Threads are smaller units of a tasks

**5 What is the ThreadPool?**
- A global queue of threads

**6 What parameters does the Task() constructor take?**
- Action delegate

**7 How do you start a thread?**
- Task.Run or .Start will start the tasks and the threads.

**8 What is the difference between the Start() and Run() methods?**
- Run() requires an aciton delegate as a parameter while start() does not

**9 What is the difference between creating independent tasks with Tasks and paralleliztion with Parallel? Explain.**
- Tasks gives more control over each task, but does not scale well
- Parallel allows to parallelize these tasks (run synchronously)

**10 Explain how manual cancellation works using a cancellation token.**
- Cancellation token is a structure that requests to cancel a task or tasks.
- A canel token is created then passed to the task that needs to be cancelled.
