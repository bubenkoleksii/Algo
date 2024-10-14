 Method                                  | Input                | Mean           | Error         | StdDev         | Median         | Rank | Gen0   | Allocated |
---------------------------------------- |--------------------- |---------------:|--------------:|---------------:|---------------:|-----:|-------:|----------:|
 GetFirstDuplicateLetter_HashSets        | aabb                 |      28.605 ns |     0.3835 ns |      0.3203 ns |      28.603 ns |    3 | 0.0401 |     168 B |
 GetFirstDuplicateLetter_ArrayWithCounts | aabb                 |      10.276 ns |     0.4884 ns |      1.4248 ns |      10.002 ns |    2 | 0.0306 |     128 B |
 GetFirstDuplicateLetter_SimpleLoops     | aabb                 |       8.397 ns |     0.3062 ns |      0.8586 ns |       8.268 ns |    1 |      - |         - |
                                         |                      |                |               |                |                |      |        |           |
 GetFirstDuplicateLetter_SimpleLoops     | aabbccddeeffgghhiijj |      98.159 ns |     2.0053 ns |      4.4018 ns |      97.864 ns |    3 |      - |         - |
 GetFirstDuplicateLetter_HashSets        | aabbccddeeffgghhiijj |      29.446 ns |     0.6158 ns |      1.5335 ns |      29.228 ns |    2 | 0.0401 |     168 B |
 GetFirstDuplicateLetter_ArrayWithCounts | aabbccddeeffgghhiijj |       9.111 ns |     0.2307 ns |      0.6583 ns |       9.010 ns |    1 | 0.0306 |     128 B |
                                         |                      |                |               |                |                |      |        |           |
 GetFirstDuplicateLetter_SimpleLoops     | abcd(...)ffff [999]  | 260,491.799 ns | 8,308.9949 ns | 24,237.7282 ns | 249,717.285 ns |    3 |      - |         - |
 GetFirstDuplicateLetter_HashSets        | abcd(...)ffff [999]  |      89.009 ns |     2.2621 ns |      6.4171 ns |      87.608 ns |    2 | 0.0802 |     336 B |
 GetFirstDuplicateLetter_ArrayWithCounts | abcd(...)ffff [999]  |      12.733 ns |     0.4581 ns |      1.2996 ns |      12.424 ns |    1 | 0.0306 |     128 B |
                                         |                      |                |               |                |                |      |        |           |
 GetFirstDuplicateLetter_HashSets        | abcdefghij           |     171.814 ns |     9.2952 ns |     26.5198 ns |     162.383 ns |    3 | 0.1585 |     664 B |
 GetFirstDuplicateLetter_SimpleLoops     | abcdefghij           |      31.497 ns |     0.6572 ns |      1.3125 ns |      31.378 ns |    2 |      - |         - |
 GetFirstDuplicateLetter_ArrayWithCounts | abcdefghij           |      13.275 ns |     0.2773 ns |      0.7910 ns |      13.126 ns |    1 | 0.0306 |     128 B |
                                         |                      |                |               |                |                |      |        |           |
 GetFirstDuplicateLetter_HashSets        | hellohe              |      41.021 ns |     0.8480 ns |      2.1891 ns |      40.557 ns |    3 | 0.0401 |     168 B |
 GetFirstDuplicateLetter_SimpleLoops     | hellohe              |      19.131 ns |     0.5045 ns |      1.4797 ns |      19.004 ns |    2 |      - |         - |
 GetFirstDuplicateLetter_ArrayWithCounts | hellohe              |       9.806 ns |     0.2297 ns |      0.5370 ns |       9.725 ns |    1 | 0.0306 |     128 B |
