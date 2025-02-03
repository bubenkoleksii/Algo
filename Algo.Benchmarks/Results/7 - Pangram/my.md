BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
11th Gen Intel Core i5-1145G7 2.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


 Method   | Test                 | Mean          | Error       | StdDev      | Median        | Ratio  | RatioSD | Gen0   | Allocated | Alloc Ratio |
--------- |--------------------- |--------------:|------------:|------------:|--------------:|-------:|--------:|-------:|----------:|------------:|
 OneLiner | abcd(...)vwxy [1000] | 5,028.9305 ns |  99.0451 ns | 110.0884 ns | 4,985.6880 ns |   9.04 |    0.63 | 0.3357 |    1408 B |          NA |
 Regex    | abcd(...)vwxy [1000] |   949.1585 ns |  18.1431 ns |  47.1564 ns |   928.6818 ns |   1.70 |    0.20 |      - |         - |          NA |
 Counters | abcd(...)vwxy [1000] |   793.8389 ns |  26.0209 ns |  75.4913 ns |   774.2151 ns |   1.41 |    0.17 | 0.0210 |      88 B |          NA |
 Mask     | abcd(...)vwxy [1000] |   567.5614 ns |  21.1490 ns |  59.6511 ns |   543.7695 ns |   1.00 |    0.00 |      - |         - |          NA |
          |                      |               |             |             |               |        |         |        |           |             |
 OneLiner | abcd(...)wxyz [1040] | 6,146.8721 ns | 289.0897 ns | 824.7892 ns | 5,905.6736 ns |   9.81 |    0.90 | 0.3357 |    1408 B |          NA |
 Regex    | abcd(...)wxyz [1040] | 1,061.2220 ns |  21.0302 ns |  54.6604 ns | 1,039.1487 ns |   1.77 |    0.10 |      - |         - |          NA |
 Counters | abcd(...)wxyz [1040] |   820.7940 ns |   6.6134 ns |   5.5225 ns |   818.3227 ns |   1.36 |    0.03 | 0.0210 |      88 B |          NA |
 Mask     | abcd(...)wxyz [1040] |   602.0782 ns |  12.0362 ns |  10.6698 ns |   596.8780 ns |   1.00 |    0.00 |      - |         - |          NA |
          |                      |               |             |             |               |        |         |        |           |             |
 OneLiner | helloworld           |   142.7572 ns |   2.7718 ns |   2.4572 ns |   141.8621 ns | 266.48 |   41.15 | 0.1032 |     432 B |          NA |
 Regex    | helloworld           |     0.9351 ns |   0.0588 ns |   0.1201 ns |     0.9020 ns |   1.89 |    0.32 |      - |         - |          NA |
 Mask     | helloworld           |     0.5021 ns |   0.0328 ns |   0.0632 ns |     0.4856 ns |   1.00 |    0.00 |      - |         - |          NA |
 Counters | helloworld           |     0.4250 ns |   0.0535 ns |   0.1017 ns |     0.4025 ns |   0.86 |    0.22 |      - |         - |          NA |
          |                      |               |             |             |               |        |         |        |           |             |
 Regex    | thequ(...)zydog [35] |   746.8985 ns |   7.4683 ns |   6.9859 ns |   745.9337 ns |  27.54 |    1.52 |      - |         - |          NA |
 OneLiner | thequ(...)zydog [35] |   471.8498 ns |  13.2282 ns |  38.7960 ns |   450.0384 ns |  17.98 |    1.88 | 0.3366 |    1408 B |          NA |
 Counters | thequ(...)zydog [35] |    81.5575 ns |   1.6094 ns |   1.4267 ns |    81.1890 ns |   3.01 |    0.20 | 0.0210 |      88 B |          NA |
 Mask     | thequ(...)zydog [35] |    26.8483 ns |   0.5635 ns |   1.0444 ns |    26.7424 ns |   1.00 |    0.00 |      - |         - |          NA |
          |                      |               |             |             |               |        |         |        |           |             |
 OneLiner | xxxx(...)xxxx [1000] | 5,046.2915 ns |  99.9233 ns | 149.5605 ns | 5,006.4068 ns |   8.39 |    0.41 | 0.0610 |     264 B |          NA |
 Counters | xxxx(...)xxxx [1000] | 1,818.0564 ns |  11.9246 ns |  10.5709 ns | 1,815.3696 ns |   3.02 |    0.18 | 0.0210 |      88 B |          NA |
 Mask     | xxxx(...)xxxx [1000] |   601.5327 ns |  11.9582 ns |  26.7462 ns |   593.2356 ns |   1.00 |    0.00 |      - |         - |          NA |
 Regex    | xxxx(...)xxxx [1000] |    80.7023 ns |   1.1672 ns |   0.9113 ns |    80.2454 ns |   0.13 |    0.01 |      - |         - |          NA |
