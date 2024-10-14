**BitMask, CustomBitVector, and BitVector32**:
These methods have constant space complexity **_(O(1))_** 
since they use fixed-size bit manipulation techniques that do not depend on the input size.

**Stackalloc**:
Also has constant space complexity **_(O(1))_** since it operates directly on the stack,
using a small fixed amount of memory.

**Contains:**
Has linear space complexity **_(O(n))_** as it needs to iterate 
through the collection for each check, allocating memory proportional to the input size.

**List and HashSet:**
Both have linear space complexity **_(O(n))_**, as they 
allocate memory proportional to the size of the input string for storing elements.
HashSet consumes more memory than List due to internal overhead.
