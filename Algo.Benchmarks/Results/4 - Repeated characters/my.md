
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1145G7 2.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]    : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  MediumRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=MediumRun  IterationCount=15  LaunchCount=2
WarmupCount=10

 Method  | Input               | Mean         | Rank | Allocated |
-------- |-------------------- |-------------:|-----:|----------:|
 Regex   | aa b(...)b aa [500] | 46,299.15 ns |    2 |  152720 B |
 Counter | aa b(...)b aa [500] |    980.31 ns |    1 |    8384 B |
         |                     |              |      |           |
 Regex   | aaaa(...)cccc [500] |  3,474.10 ns |    2 |    1488 B |
 Counter | aaaa(...)cccc [500] |    290.75 ns |    1 |      88 B |
         |                     |              |      |           |
 Regex   | aaabbbcccaaa        |    599.22 ns |    2 |    1896 B |
 Counter | aaabbbcccaaa        |     21.93 ns |    1 |      88 B |
         |                     |              |      |           |
 Regex   | abba                |    425.88 ns |    2 |    1488 B |
 Counter | abba                |     17.93 ns |    1 |      88 B |
