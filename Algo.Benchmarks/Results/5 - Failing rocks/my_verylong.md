
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1145G7 2.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]      : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  VeryLongRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=VeryLongRun  IterationCount=500  LaunchCount=4  
WarmupCount=30  

 Method                  | Test                 | Mean          | Error        | StdDev        | Median        | Gen0    | Allocated |
------------------------ |--------------------- |--------------:|-------------:|--------------:|--------------:|--------:|----------:|
 Matrix                  |     (...)     [4222] |  23,714.16 ns |    68.799 ns |    882.386 ns |  23,595.21 ns | 10.0403 |   42024 B |
 ColumnsCountStepSb      |     (...)     [4222] |  15,761.46 ns |    37.172 ns |    491.127 ns |  15,901.09 ns |  4.0588 |   16992 B |
 ColumnsCountStepCharArr |     (...)     [4222] |   6,512.65 ns |    42.707 ns |    560.660 ns |   6,324.33 ns |  4.0436 |   16944 B |
                         |                      |               |              |               |               |         |           |
 Matrix                  | #\r\n                |     106.16 ns |     0.136 ns |      1.710 ns |     106.01 ns |  0.0516 |     216 B |
 ColumnsCountStepSb      | #\r\n                |      31.91 ns |     0.055 ns |      0.692 ns |      31.84 ns |  0.0325 |     136 B |
 ColumnsCountStepCharArr | #\r\n                |      18.33 ns |     0.087 ns |      1.119 ns |      18.34 ns |  0.0153 |      64 B |
                         |                      |               |              |               |               |         |           |
 ColumnsCountStepSb      | # # (...) # # [4222] | 152,210.99 ns | 1,098.495 ns | 13,853.525 ns | 145,468.46 ns |  3.9063 |   16992 B |
 Matrix                  | # # (...) # # [4222] |  85,294.35 ns |    82.592 ns |  1,052.428 ns |  85,327.88 ns | 10.0098 |   42024 B |
 ColumnsCountStepCharArr | # # (...) # # [4222] |  71,754.52 ns |    96.154 ns |  1,209.455 ns |  71,605.04 ns |  4.0283 |   16944 B |
                         |                      |               |              |               |               |         |           |
 ColumnsCountStepSb      | ####(...)     [4222] | 248,738.70 ns |   457.475 ns |  5,797.794 ns | 247,422.75 ns |  3.9063 |   16992 B |
 Matrix                  | ####(...)     [4222] | 121,871.77 ns |   188.520 ns |  2,372.661 ns | 121,632.40 ns | 10.0098 |   42024 B |
 ColumnsCountStepCharArr | ####(...)     [4222] | 103,599.51 ns |   207.164 ns |  2,596.646 ns | 103,898.39 ns |  4.0283 |   16944 B |
                         |                      |               |              |               |               |         |           |
 ColumnsCountStepSb      | ####(...)#### [4222] | 222,084.08 ns |   986.301 ns | 12,628.564 ns | 220,937.70 ns |  3.9063 |   16992 B |
 Matrix                  | ####(...)#### [4222] | 143,459.83 ns |   192.956 ns |  2,439.090 ns | 143,280.65 ns | 10.0098 |   42024 B |
 ColumnsCountStepCharArr | ####(...)#### [4222] | 103,931.62 ns |   753.367 ns |  9,746.103 ns |  99,886.17 ns |  4.0283 |   16944 B |

Global total time: 24:21:30 (87690.64 sec), executed benchmarks: 15
