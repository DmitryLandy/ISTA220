# Classes
---
Classes are:

* objects contains a memory address
* Also a reference type
* Object-Oriented programming is a good way to organize code

```Duck donald = new Duck();```

```Int age = new Int(71); //this is the same as Int age = 71;```

Two kinds of memory:
- Stack 
	- organized memory, such as within the {....}
	- this is the working memory
- Heap 
	- unorganized memory
	- area of memory that has access to everything
	- surplus to requirements (vacant land)

"New" keyword allocates memory from the heap. Just enough memory to hold the new defined object. It then returns the memory address to the object variable.

Class fields vs instance fields:
- Class fields defined with "static" keyword within the class
- Instance fields are defined via the object instance of that class

```
class Bob
{
	static var; //class field
	static method() //class method
}

Bob rob = new Bob(); //instance
rob.method("instance method"); //instance method
```

```Static``` creates a class member
- class variables are shared amongs all objects of the class