
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1145G7 2.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


 Method             | Input                | Mean           | Error       | StdDev        | Median         | Gen0   | Allocated |
------------------- |--------------------- |---------------:|------------:|--------------:|---------------:|-------:|----------:|
 RowIdLoopFrozenSet | hElLoWoRlD           |  3,974.6924 ns | 332.7476 ns |   975.8910 ns |  3,785.0023 ns | 1.6212 |    6792 B |
 RowIdLoopHashSet   | hElLoWoRlD           |  1,607.2116 ns | 211.4278 ns |   623.3996 ns |  1,280.3082 ns | 0.8202 |    3432 B |
 RowIdLoopDistinct  | hElLoWoRlD           |    448.2244 ns |  52.3616 ns |   154.3895 ns |    393.7383 ns | 0.1144 |     480 B |
 Regex              | hElLoWoRlD           |     30.3664 ns |   1.0893 ns |     3.0723 ns |     29.2391 ns |      - |         - |
 RowIdLoop          | hElLoWoRlD           |     23.0782 ns |   1.0436 ns |     2.9942 ns |     22.2693 ns | 0.0115 |      48 B |
                    |                      |                |             |               |                |        |           |
 RowIdLoopDistinct  | qwer(...)IOPM [1001] | 16,342.5020 ns | 633.7241 ns | 1,787.4301 ns | 15,488.1195 ns | 0.1831 |     808 B |
 RowIdLoopFrozenSet | qwer(...)IOPM [1001] |  8,665.5507 ns | 462.6935 ns | 1,364.2621 ns |  8,279.2194 ns | 1.6174 |    6792 B |
 RowIdLoopHashSet   | qwer(...)IOPM [1001] |  6,858.6149 ns | 207.2035 ns |   594.5057 ns |  6,636.4754 ns | 0.8163 |    3432 B |
 RowIdLoop          | qwer(...)IOPM [1001] |  5,947.4323 ns | 181.1981 ns |   499.0723 ns |  5,860.4095 ns | 0.0076 |      48 B |
 Regex              | qwer(...)IOPM [1001] |     43.2757 ns |   0.9093 ns |     2.5197 ns |     43.2794 ns |      - |         - |
                    |                      |                |             |               |                |        |           |
 RowIdLoopHashSet   | X                    |      2.4924 ns |   0.1128 ns |     0.1756 ns |      2.4967 ns |      - |         - |
 RowIdLoopDistinct  | X                    |      1.5399 ns |   0.1522 ns |     0.4415 ns |      1.3928 ns |      - |         - |
 Regex              | X                    |      1.2394 ns |   0.1108 ns |     0.3180 ns |      1.1703 ns |      - |         - |
 RowIdLoopFrozenSet | X                    |      1.1106 ns |   0.3254 ns |     0.9596 ns |      1.1659 ns |      - |         - |
 RowIdLoop          | X                    |      0.5875 ns |   0.0866 ns |     0.2456 ns |      0.5320 ns |      - |         - |
                    |                      |                |             |               |                |        |           |
 RowIdLoopDistinct  | XXXX(...)XXXX [1000] | 17,099.7939 ns | 662.9534 ns | 1,869.8718 ns | 16,525.4517 ns | 0.0610 |     312 B |
 RowIdLoopHashSet   | XXXX(...)XXXX [1000] | 15,839.9323 ns | 778.0986 ns | 2,194.6410 ns | 15,268.4525 ns | 0.7935 |    3432 B |
 RowIdLoopFrozenSet | XXXX(...)XXXX [1000] | 14,949.4464 ns | 579.5737 ns | 1,653.5564 ns | 14,470.9511 ns | 1.6174 |    6792 B |
 RowIdLoop          | XXXX(...)XXXX [1000] | 14,649.0935 ns | 647.0943 ns | 1,803.8402 ns | 14,076.4191 ns |      - |      48 B |
 Regex              | XXXX(...)XXXX [1000] |     44.2307 ns |   1.1933 ns |     3.3264 ns |     43.7030 ns |      - |         - |
