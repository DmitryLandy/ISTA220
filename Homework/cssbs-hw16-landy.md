## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 16
## DATE: 3/3/2021
---
**1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.**

- ~, <<, |, &, ^, >> 

**2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valie C# code.**

- 8>>2 would be 2

**3. Explain in detail this code: bits & (1 << index);.**

- 1 gets its bits moved to the left by index amount then bit-wise AND operation occurs with the "bits" number

**4. Explain in detail this code: bits |= (1 << index);.**

- 1 gets its bits moved to the left by index amount then bit-wise OR operation occurs with the "bits" number. The result is stored in bits variable.

**5. Explain in detail this code: bits &= (1 << index);.**

- 1 gets its bits moved to the left by index amount then bit-wise AND operation occurs with the "bits" number. The result is stored in bits variable.

**6. How does C# interpret this? bool peek = bits[n];**

- It gets the bit in index n and sets it to peek. 1= true, 0 = false

**7. How does C# interpret this? bits[n] = true;**

- bit at index n is set to 1

**8. How does C# interpret this? bits[n] ^= true;**

- bits[n] = bits[n] ^ true;
- XOR bitwise operation with 1 and value at index n in bits

**9. Assume that users were assigned read, write, and execute permissions according to this scheme: read = 1, write = 2, execute = 4. How would you interpret the following user permissions:**
```
(a) permission = 0 // 000 ---
(b) permission = 1 // 001 --r
(c) permission = 2 // 010 -w-
(d) permission = 3 // 011 -wr
(e) permission = 4 // 100 x--
(f) permission = 5 // 101 x-r
(g) permission = 6 // 110 xw-
(h) permission = 7 // 111 xwr
```
**10. Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this scheme of permissions?**

- The permissions correlate to the octal value of the decimal number
