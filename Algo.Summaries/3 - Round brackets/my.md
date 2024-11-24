- First solution: Two id arrays:
  - Time complexity:  
    3 <= O(n + n / 2 ) <= 1_500, 
    n є 2Z, 
    COUNT(open) = COUNT(closed)

  - Space complexity:  
    4 <= O(2n) <= 2_000,
    n є 2Z

- Second solution: Stack
  - Time complexity:  
    2 <= O(n) <= 1_000 
    n є 2Z, 
    COUNT(open) = COUNT(closed)

  - Space complexity:  
    1 <= O(n / 2) <= 500,
    n є 2Z

- Third solution: Counter
  - Time complexity:  
      2 <= O(n) <= 100,
      n є 2Z

  - Space complexity:  
      O(1)
