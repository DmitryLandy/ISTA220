#### NAME: Dmitry Landy 
#### ASSIGNMENT: C# Chapter 10 Homework 
#### DATE: 2/10/2020
---
**1. What does an array look like in memory?**

- Live in a contiguous (connected) block of memory and accessed by using the index

**2. Where is memory allocated to hold an array, on the stack or on the heap?**

- Arrays are reference types, regardless of the types it holds
- Holds the element on the heap.

**3. Where is memory allocated to hold an array reference, on the stack or on the heap?**

- Array reference is stored on the stack.

**4. Can an array hold values of different types? This is a trick question, the answer is, “It depends.” What determines the types that an array can hold?**

- Array can only hold values of the same type within it.
- This type is determined by type in the declaration

**5. Describe the syntax of the condition for a foreach loop.**
```
foreach ( int x in arrayName)
{
	//body
}
```
**6. How do you make a deep copy of a array?**

- use a for loop to retrieved the data in the memory address and put it into a copy array

**7. What is the difference in the syntax between a multi-dimensional array and an array of arrays?**

- 1D array: int[] 1DArray = new int[5];
- 2D array: int[,] 2Darray = new int[4,5];

- jagged array: 
```
int[][] jag= new int[4][];
int[] row0 = new int[2];
int[] row1 = new int[6]
...

jag[0] = row0;
jag[1] = row1;
...
```
**8. What is the difference in the uses for a multi-dimensional array and an array of arrays? In other words, what determines whether you would use one as opposed to the other?**

- If you know how much space to allocate for the array of arrays.
- multi-dimensional array has rows and columns
- jagged arrays have varying columns in rows.

**9. How do you “flatten” a multidimensional array? In other words, take something that looks like a matrix**
```
1 2 3
4 5 6
7 8 9
```
**and turn it into an array [1, 2, 3, 4, 5, 6, 7, 8, 9]? Write the code to do this in English.**

```
int[] flatAry= new int[s.length * t.length];

for(s loop)
	for(t loop)
		flatAry[i] = s[i][i]
```

**10. (Thought question) When we use a for loop, we can change the values of the array elements inside the loop. When we use a foreach loop, we cannot change the values of the arry elements inside the loop. Why not? How is for different from foreach?**

- foreach simply iterates through the array without getting the references of the elements in the array during the process. It de-references the elements of the array and just gets the values.
