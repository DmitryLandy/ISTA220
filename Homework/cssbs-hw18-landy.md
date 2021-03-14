## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 18
## DATE: 3/11/2021
---
**1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a ticked just submitted. What kind of data structure would you use, and why?**

-Queue, first in first out

**2. You are building a tracking system for seasonal agricultural farm labor. Te labor requirements vary widely, depending on the season. Your requirement is that the newest hires are terminated first, and that our more experienced hires are kept longer. What kind of data structure would you use, and why?**

- Stack, first in last out or last in first out

**3. You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why?**

- List because you can add data and you can insert or remove data as needed.

**4. You are building an analytical database. Your requirement is that the database handle queries very quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind of data structure would you use, and why?**

- A HashSet or SortedList because they supports fast retrieval of data. 

**5. You are building a personnel directory, where searched are performed by last name, first name, middle name. What kind of data structure would you use, and why?**

- A Dictionary, fast retrieval and ability to expand.

**6. You are building a username/password database. Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happenb extremely quickly. What kind of data structure would you use, and why?**

- SortedDictionary because you can query quickly to make updates.

**7. What is a lambda expression? Give an example. Why would we use a lambda expression?**

- An expression that returns a method instead of a value. 
- Used to perform in-line processing

**8. What is the difference between lambda expressions and anonymous methods? What are the advantages of each?**

- Anonymous method uses "delegate" keyword.
- not as flexible as lamda expressions 
- lamda expressoins are preferred.