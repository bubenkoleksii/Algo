Task: Find first duplicate letter

- with the string str, return the first letter that is found twice
- 2 <= str.Length <= 1000
- only a-z in the string (only lowercase)
- the string is guaranteed to have a duplicate

1. First solution: SimpleLoops
    - Time complexity: O(n^2)
    - Space complexity: O(1)

2. Second solution: ArrayWithCounts
    - Time complexity: O(n)
    - Space complexity: O(1) 

3. Third solution: HashSets
    - Time complexity: O(n)
    - Space complexity: O(n)

**Conclusion:**
It appeared that the second solution is the most effective for this test data, 
but if the characters were any and not a-z, the third solution would be better
