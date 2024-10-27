
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4169/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1145G7 2.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]    : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2  
WarmupCount=10  

 Method                         | N                    | Mean        | Rank | Allocated |
------------------------------- |--------------------- |------------:|-----:|----------:|
 TwoStringUnoptimized           | 0                    |  79.7913 ns |    4 |     168 B |
 TwoString                      | 0                    |   0.8180 ns |    3 |         - |
 SingleStringSpan               | 0                    |   0.7573 ns |    3 |         - |
 SingleString                   | 0                    |   0.6747 ns |    3 |         - |
 SequenceEquals                 | 0                    |   0.5844 ns |    3 |         - |
 LongReverse                    | 0                    |   0.4973 ns |    2 |         - |
 LongReverse_AggressiveInlining | 0                    |   0.0615 ns |    1 |         - |
                                |                      |             |      |           |
 TwoStringUnoptimized           | 10000000000000000000 | 217.8480 ns |    4 |     560 B |
 SingleStringSpan               | 10000000000000000000 |   0.9651 ns |    3 |         - |
 SequenceEquals                 | 10000000000000000000 |   0.7763 ns |    3 |         - |
 LongReverse                    | 10000000000000000000 |   0.7288 ns |    3 |         - |
 TwoString                      | 10000000000000000000 |   0.7180 ns |    3 |         - |
 SingleString                   | 10000000000000000000 |   0.5662 ns |    2 |         - |
 LongReverse_AggressiveInlining | 10000000000000000000 |   0.3696 ns |    1 |         - |
                                |                      |             |      |           |
 TwoStringUnoptimized           | 5                    |  97.7542 ns |    4 |     168 B |
 SingleStringSpan               | 5                    |   1.0715 ns |    3 |         - |
 SequenceEquals                 | 5                    |   0.9581 ns |    3 |         - |
 TwoString                      | 5                    |   0.8427 ns |    2 |         - |
 LongReverse                    | 5                    |   0.6734 ns |    2 |         - |
 SingleString                   | 5                    |   0.6609 ns |    2 |         - |
 LongReverse_AggressiveInlining | 5                    |   0.3211 ns |    1 |         - |
                                |                      |             |      |           |
 SequenceEquals                 | 121                  |  78.0113 ns |    6 |      64 B |
 TwoStringUnoptimized           | 121                  |  77.4303 ns |    6 |     176 B |
 TwoString                      | 121                  |  19.8537 ns |    5 |      64 B |
 LongReverse_AggressiveInlining | 121                  |   7.0016 ns |    4 |         - |
 LongReverse                    | 121                  |   4.5775 ns |    3 |         - |
 SingleStringSpan               | 121                  |   3.4563 ns |    2 |         - |
 SingleString                   | 121                  |   2.8600 ns |    1 |         - |
                                |                      |             |      |           |
 TwoStringUnoptimized           | 12345654321          | 189.8313 ns |    5 |     384 B |
 SequenceEquals                 | 12345654321          | 105.1372 ns |    4 |     144 B |
 TwoString                      | 12345654321          |  45.1307 ns |    3 |     144 B |
 LongReverse                    | 12345654321          |  24.1696 ns |    2 |         - |
 SingleString                   | 12345654321          |  23.7923 ns |    2 |      48 B |
 SingleStringSpan               | 12345654321          |  23.2436 ns |    2 |      48 B |
 LongReverse_AggressiveInlining | 12345654321          |  21.0612 ns |    1 |         - |
                                |                      |             |      |           |
 TwoStringUnoptimized           | 18446744066044764481 | 244.4268 ns |    5 |     560 B |
 SequenceEquals                 | 18446744066044764481 |  87.3005 ns |    4 |     192 B |
 TwoString                      | 18446744066044764481 |  48.2404 ns |    3 |     192 B |
 LongReverse_AggressiveInlining | 18446744066044764481 |  39.3634 ns |    2 |         - |
 LongReverse                    | 18446744066044764481 |  39.2328 ns |    2 |         - |
 SingleString                   | 18446744066044764481 |  32.4256 ns |    1 |      64 B |
 SingleStringSpan               | 18446744066044764481 |  28.0417 ns |    1 |      64 B |
                                |                      |             |      |           |
 TwoStringUnoptimized           | 18446744066144764481 | 270.0634 ns |    6 |     560 B |
 SequenceEquals                 | 18446744066144764481 |  85.9714 ns |    5 |     192 B |
 TwoString                      | 18446744066144764481 |  69.0407 ns |    4 |     192 B |
 SingleString                   | 18446744066144764481 |  47.0145 ns |    3 |      64 B |
 LongReverse_AggressiveInlining | 18446744066144764481 |  40.1502 ns |    2 |         - |
 LongReverse                    | 18446744066144764481 |  39.3523 ns |    2 |         - |
 SingleStringSpan               | 18446744066144764481 |  32.3326 ns |    1 |      64 B |
                                |                      |             |      |           |
 TwoStringUnoptimized           | 18446744073709551615 | 209.2739 ns |    5 |     560 B |
 SequenceEquals                 | 18446744073709551615 |  84.7021 ns |    4 |     192 B |
 TwoString                      | 18446744073709551615 |  43.5756 ns |    3 |     192 B |
 LongReverse                    | 18446744073709551615 |  39.2113 ns |    2 |         - |
 LongReverse_AggressiveInlining | 18446744073709551615 |  39.0919 ns |    2 |         - |
 SingleStringSpan               | 18446744073709551615 |  22.5283 ns |    1 |      64 B |
 SingleString                   | 18446744073709551615 |  22.1490 ns |    1 |      64 B |
