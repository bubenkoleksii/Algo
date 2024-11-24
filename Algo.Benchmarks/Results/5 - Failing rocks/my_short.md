
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1145G7 2.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


 Method                  | Test                 | Mean          | Error        | StdDev        | Median        | Gen0    | Gen1   | Allocated |
------------------------ |--------------------- |--------------:|-------------:|--------------:|--------------:|--------:|-------:|----------:|
 Matrix                  |     (...)     [4222] |  27,352.03 ns |   728.722 ns |  2,079.085 ns |  26,708.59 ns | 10.0403 |      - |   42024 B |
 ColumnsCountStepSb      |     (...)     [4222] |  17,840.27 ns |   493.983 ns |  1,417.329 ns |  17,435.49 ns |  4.0588 |      - |   16992 B |
 ColumnsCountStepCharArr |     (...)     [4222] |   7,047.65 ns |   137.593 ns |    222.187 ns |   6,990.03 ns |  4.0436 |      - |   16944 B |
                         |                      |               |              |               |               |         |        |           |
 Matrix                  | #\r\n                |     134.28 ns |     3.979 ns |     11.417 ns |     129.96 ns |  0.0515 |      - |     216 B |
 ColumnsCountStepSb      | #\r\n                |      35.69 ns |     0.774 ns |      1.698 ns |      35.39 ns |  0.0325 |      - |     136 B |
 ColumnsCountStepCharArr | #\r\n                |      21.13 ns |     0.554 ns |      1.582 ns |      20.53 ns |  0.0153 |      - |      64 B |
                         |                      |               |              |               |               |         |        |           |
 ColumnsCountStepSb      | # # (...) # # [4222] | 184,436.36 ns | 5,063.870 ns | 14,691.205 ns | 178,685.03 ns |  3.9063 |      - |   16992 B |
 Matrix                  | # # (...) # # [4222] |  92,900.08 ns | 1,715.476 ns |  3,465.347 ns |  91,934.10 ns | 10.0098 |      - |   42024 B |
 ColumnsCountStepCharArr | # # (...) # # [4222] |  89,393.71 ns | 1,707.932 ns |  1,514.037 ns |  89,880.10 ns |  4.0283 |      - |   16944 B |
                         |                      |               |              |               |               |         |        |           |
 ColumnsCountStepSb      | ####(...)     [4222] | 271,583.25 ns | 7,002.017 ns | 19,749.313 ns | 267,153.34 ns |  3.9063 |      - |   16992 B |
 Matrix                  | ####(...)     [4222] | 127,277.54 ns | 2,541.182 ns |  3,304.254 ns | 126,362.81 ns | 10.0098 | 0.4883 |   42024 B |
 ColumnsCountStepCharArr | ####(...)     [4222] | 116,878.73 ns | 3,066.714 ns |  8,945.748 ns | 114,019.70 ns |  3.9063 |      - |   16944 B |
                         |                      |               |              |               |               |         |        |           |
 ColumnsCountStepSb      | ####(...)#### [4222] | 235,763.57 ns | 4,890.677 ns | 13,953.376 ns | 232,355.41 ns |  3.9063 |      - |   16992 B |
 Matrix                  | ####(...)#### [4222] | 155,986.23 ns | 2,515.541 ns |  5,360.823 ns | 154,357.67 ns | 10.0098 |      - |   42024 B |
 ColumnsCountStepCharArr | ####(...)#### [4222] |  96,087.30 ns | 1,456.652 ns |  2,180.248 ns |  95,584.75 ns |  4.0283 |      - |   16944 B |
