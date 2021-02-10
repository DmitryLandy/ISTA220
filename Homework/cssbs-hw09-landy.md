#### NAME: Dmitry Landy 
#### ASSIGNMENT: C# Chapter 9 Homework 
#### DATE: 2/9/2020
---
**1. What is an enum?**

- It is a type that can store a set of constant value type names. That variable is only able to be one of the values in the set.

**2. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, Corporal, Sergeant or Lieutenant, Captain, Major?**

- ```enum Rank = {PVT, PV2, PFC, SPC}```

**3. Using the Ranks enum, assign a rank to yourself and a friend.**

- ``` Rank first = Rank.PVT;```

**4. Determine the numeric index of particular ranks, using the Ranks enum.**

- ```enum Rank = {PVT = 1, PV2, PFC, SPC}```

**5. How do you select the type of an enum?**

- ```enum Rank : String = {PVT, PV2, PFC, SPC}```

**6. What is a struct?**

- A value type (stored on a stack, so reasonably small)
- Its almost exactly like a class, but its a value type

**7. List some differences between classes and structs.**

- Heap vs Stack
- Structure instances are called values
- structs can't declare default constructor

**8. Are structs stored on the stack or on the heap? What about enums?**

- Structs are on the stack
- enums are value types so stack

**9. Review the documentation for the C# System.Int32 struct. List the fields. List the methods.**

- Fields:
	- MaxValue, MinValue
- Methods:
	- CompareTo, Equals, GethashCode, GetTypeCode, Parse, ToString, TryFormat, TryParse

**10. Declare a struct named DOD with four branches.**

- ``` 
struct DOD 
{ 
	enum branches = { Army, Navy, AirForce, CoastGuard}
	branches Army = branches.Army;
	branches Navy = branches.Navy;
}```

**11. Why can’t you create a default constructor for a struct?**

- compiler always generates one, and then sets field to 0, false, or null.

**12. What is CIL? What does the CLR do to the CIL?**

- CIL is the common intermediate language (what computer reads)
- CLR common language runtime converts code into CIL for the machine.
