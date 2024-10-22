
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4169/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1145G7 2.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]  : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

 Method        | Input                | Mean       | Error     | StdDev     | Median     | Rank | Gen0   | Allocated |
-------------- |--------------------- |-----------:|----------:|-----------:|-----------:|-----:|-------:|----------:|
 DivideStrings | 121                  | 118.898 ns | 2.4121 ns | 12.1363 ns | 115.549 ns |    3 | 0.0515 |     216 B |
 Division      | 121                  |   8.155 ns | 0.1078 ns |  0.5353 ns |   8.136 ns |    2 |      - |         - |
 ReverseNumber | 121                  |   5.784 ns | 0.1524 ns |  0.7640 ns |   5.580 ns |    1 |      - |         - |
               |                      |            |           |            |            |      |        |           |
 DivideStrings | 100001               | 183.262 ns | 5.4614 ns | 27.9263 ns | 174.715 ns |    3 | 0.0668 |     280 B |
 ReverseNumber | 100001               |  15.760 ns | 0.3123 ns |  1.6111 ns |  15.606 ns |    2 |      - |         - |
 Division      | 100001               |  12.599 ns | 0.2474 ns |  1.2631 ns |  12.341 ns |    1 |      - |         - |
               |                      |            |           |            |            |      |        |           |
 DivideStrings | 100010               | 116.693 ns | 1.4929 ns |  7.5526 ns | 116.868 ns |    3 | 0.0669 |     280 B |
 ReverseNumber | 100010               |  10.833 ns | 0.0620 ns |  0.3041 ns |  10.810 ns |    2 |      - |         - |
 Division      | 100010               |   9.094 ns | 0.3939 ns |  1.9856 ns |   9.982 ns |    1 |      - |         - |
               |                      |            |           |            |            |      |        |           |
 DivideStrings | 12345654321          | 149.394 ns | 0.8076 ns |  3.9048 ns | 148.891 ns |    3 | 0.0801 |     336 B |
 Division      | 12345654321          |  52.147 ns | 0.2964 ns |  1.4361 ns |  51.716 ns |    2 |      - |         - |
 ReverseNumber | 12345654321          |  23.123 ns | 0.1931 ns |  0.9373 ns |  23.327 ns |    1 |      - |         - |
               |                      |            |           |            |            |      |        |           |
 DivideStrings | 10000000000000000000 | 217.209 ns | 1.7503 ns |  8.5787 ns | 214.659 ns |    3 | 0.1070 |     448 B |
 ReverseNumber | 10000000000000000000 |  48.633 ns | 1.0004 ns |  5.0701 ns |  48.712 ns |    2 |      - |         - |
 Division      | 10000000000000000000 |  28.033 ns | 0.2482 ns |  1.2187 ns |  27.552 ns |    1 |      - |         - |
               |                      |            |           |            |            |      |        |           |
 DivideStrings | 18446744066044764481 | 186.406 ns | 3.9366 ns | 19.3681 ns | 178.949 ns |    3 | 0.1070 |     448 B |
 Division      | 18446744066044764481 | 109.574 ns | 2.4486 ns | 12.4983 ns | 106.442 ns |    2 |      - |         - |
 ReverseNumber | 18446744066044764481 |  42.572 ns | 1.0235 ns |  5.1216 ns |  40.138 ns |    1 |      - |         - |
               |                      |            |           |            |            |      |        |           |
 DivideStrings | 18446744066144764481 | 201.564 ns | 8.8868 ns | 44.7948 ns | 175.325 ns |    3 | 0.1070 |     448 B |
 Division      | 18446744066144764481 |  85.026 ns | 0.3811 ns |  1.8535 ns |  84.652 ns |    2 |      - |         - |
 ReverseNumber | 18446744066144764481 |  39.909 ns | 0.1609 ns |  0.7670 ns |  39.737 ns |    1 |      - |         - |
               |                      |            |           |            |            |      |        |           |
 DivideStrings | 18446744073709551615 | 173.351 ns | 0.5996 ns |  2.9104 ns | 172.952 ns |    3 | 0.1070 |     448 B |
 ReverseNumber | 18446744073709551615 |  40.009 ns | 0.1334 ns |  0.6438 ns |  39.832 ns |    2 |      - |         - |
 Division      | 18446744073709551615 |  24.218 ns | 0.1183 ns |  0.5796 ns |  24.311 ns |    1 |      - |         - |
