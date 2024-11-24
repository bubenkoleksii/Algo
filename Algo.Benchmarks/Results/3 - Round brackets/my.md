
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4169/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1145G7 2.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


 Method      | Input                | Mean          | Rank | Allocated |
------------ |--------------------- |--------------:|-----:|----------:|
 TwoIdArrays | ((((...)))) [10000]  | 27,073.394 ns |    3 |   80112 B |
 Stack       | ((((...)))) [10000]  | 22,413.146 ns |    2 |   65840 B |
 Counter     | ((((...)))) [10000]  |  5,225.352 ns |    1 |         - |
             |                      |               |      |           |
 Stack       | (()((...))()( [9998] | 18,206.837 ns |    3 |      72 B |
 TwoIdArrays | (()((...))()( [9998] | 12,857.559 ns |    2 |   80096 B |
 Counter     | (()((...))()( [9998] |  5,135.481 ns |    1 |         - |
             |                      |               |      |           |
 Stack       | (())                 |     27.394 ns |    2 |      72 B |
 TwoIdArrays | (())                 |     25.322 ns |    2 |     144 B |
 Counter     | (())                 |      5.786 ns |    1 |         - |
             |                      |               |      |           |
 TwoIdArrays | ()                   |     29.447 ns |    3 |     128 B |
 Stack       | ()                   |     23.558 ns |    2 |      72 B |
 Counter     | ()                   |      3.019 ns |    1 |         - |
             |                      |               |      |           |
 Stack       | ()((...))() [10000]  | 22,822.405 ns |    2 |      72 B |
 TwoIdArrays | ()((...))() [10000]  | 22,434.771 ns |    2 |   80112 B |
 Counter     | ()((...))() [10000]  |  6,140.348 ns |    1 |         - |
