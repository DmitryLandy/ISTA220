#### NAME: Dmitry Landy 
#### ASSIGNMENT: C# Chapter 5 Homework 
#### DATE: 1/26/2020
---
**1. What is a compound assignment operator? How does it work?**

- Operator that combines arithmetic operator with assignment operator
- It simplifies the length of the expression by combining the operators.

**2. List all the compound assignment operators.**

- ``` +=, -=, *=, /=, %= ```

**3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50.**

- += 5, var = var + 5;
- -= 50, var = var - 50;

**4. How long does a while loop run?**

- As long as the boolean expression is true

**5. What is an iteration variable? (Not in book)**

- A variable that is used to iterate (go through sequentially) through the loop. The loop is dependant on that variable in a predicate expression

**6. What happens if you don’t change the loop variable in the body of the while loop block?**

- The loop will not stop

**7. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them?**

- 3: init, boolean expression, update control variable
- The init, boolean expression, and update variable can be omitted.
- The loop will never end if they are omitted.

**8. How do you guarantee that a loop runs at least once?**

- use the do while loop

**9. What does the break statement do?**

- breaks the exection of the code out of the body its in.
- terminates the loop it is in

**10. What does the continue statement do?**

- causes the program to execute the next iteration of the loop.

**11. (Thought question) Can you think of any reason why you would want to have an infinite loop? An “infinite loop” is a loop without an update variable that in effect runs forever. As you will see, these kinds of loops are written intentionally to perform various kinds of tasks.**

- For testing
- web servers
- daemon



