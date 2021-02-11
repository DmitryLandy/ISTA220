# Arrays
---
Arrays are stored on the heap but the reference is on the stack. it can store only a single type within its set:
```
int[] chat = new int[5]; //holds five integer elements
object[] obj01 = new object[5]; //holds five object element references
								//those references are the memory address to the actual value on the heap.
```

The way the computer accesses the elements of an array is by pointer arithmetic.

The formula is:
- memory_address = index +(type_size * index)

The index (which is the stuff that goes into the square brackets) can be:
- numeric literal (i.e. int, double, etc) == chad[0]
- expression (i.e. mathematical exression) == chad[3+2]
- variable (e.g. compute a variable) 	   == chad [myVar]
- method 								 == chad [myMethod()] or chad[myMethod(x,y,z)]
