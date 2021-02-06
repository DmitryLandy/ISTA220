# Stacks, Heaps, and Data Values
---

**Stacks**: 
- used for value types. Specific amount of memory is set aside

**Heap**: 
- Used for reference types. It stores the values of the reference (which is stored in the stack)

**Value Types**
- Contains data of a value type (int, float, char, etc.) stored directly in the stack

**Reference Types**
- Contains the memory of reference type (object such as String).

**References**: 
- Memory locations on the heap that contain the actual data
- Can hold NULL, but when that data is accessed an exceptition is returned.

**NULL/NON-NULL**
```
int alice = 1;
int? bob = 2;
alice = bob; //Illegal because non-null can't be assigned null
bob = alice; //Legal!
```
