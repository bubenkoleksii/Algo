
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1145G7 2.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]  : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI [AttachedDebugger]
  LongRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  IterationCount=100  LaunchCount=3  
WarmupCount=15  

 Method                                  | Mean       | Error    | StdDev    | Median     | Gen0   | Allocated |
---------------------------------------- |-----------:|---------:|----------:|-----------:|-------:|----------:|
 GetFirstDuplicateLetter_SimpleLoops     | 4,869.2 ns | 40.99 ns | 209.22 ns | 4,876.0 ns | 0.1297 |     568 B |
 GetFirstDuplicateLetter_ArrayWithCounts |   223.0 ns |  1.97 ns |   9.77 ns |   221.2 ns | 0.5641 |    2360 B |
 GetFirstDuplicateLetter_HashSets        | 1,414.9 ns | 25.82 ns | 131.32 ns | 1,394.0 ns | 1.2932 |    5416 B |
