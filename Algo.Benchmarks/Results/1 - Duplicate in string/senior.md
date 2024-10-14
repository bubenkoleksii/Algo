| Method          | Input                | Mean       | Error     | StdDev     | Median      | Rank | Gen0   | Allocated |
|---------------- |--------------------- |-----------:|----------:|-----------:|------------:|-----:|-------:|----------:|
| HashSet         | aa                   |  29.055 ns | 0.7324 ns |  1.0962 ns |  28.8493 ns |    6 | 0.0803 |     168 B |
| List            | aa                   |  17.198 ns | 0.1607 ns |  0.2355 ns |  17.1367 ns |    5 | 0.0306 |      64 B |
| Contains        | aa                   |   8.074 ns | 0.0980 ns |  0.1374 ns |   8.0178 ns |    4 | 0.0115 |      24 B |
| Stackalloc      | aa                   |   2.370 ns | 0.0089 ns |  0.0133 ns |   2.3650 ns |    3 |      - |         - |
| BitVector32     | aa                   |   1.723 ns | 0.0480 ns |  0.0718 ns |   1.7042 ns |    2 |      - |         - |
| CustomBitVector | aa                   |   1.009 ns | 0.0328 ns |  0.0481 ns |   0.9895 ns |    1 |      - |         - |
| BitMask         | aa                   |   1.006 ns | 0.0342 ns |  0.0501 ns |   0.9797 ns |    1 |      - |         - |

| HashSet         | abccbaacz            |  43.146 ns | 0.4321 ns |  0.6333 ns |  43.1759 ns |    7 | 0.0803 |     168 B |
| List            | abccbaacz            |  29.245 ns | 0.6712 ns |  0.9626 ns |  28.8429 ns |    6 | 0.0306 |      64 B |
| Contains        | abccbaacz            |  26.389 ns | 0.6791 ns |  0.9954 ns |  26.0023 ns |    5 | 0.0421 |      88 B |
| Stackalloc      | abccbaacz            |   3.609 ns | 0.0537 ns |  0.0787 ns |   3.5937 ns |    4 |      - |         - |
| BitVector32     | abccbaacz            |   3.450 ns | 0.0215 ns |  0.0322 ns |   3.4472 ns |    3 |      - |         - |
| CustomBitVector | abccbaacz            |   2.813 ns | 0.0087 ns |  0.0118 ns |   2.8082 ns |    2 |      - |         - |
| BitMask         | abccbaacz            |   2.409 ns | 0.0338 ns |  0.0485 ns |   2.3984 ns |    1 |      - |         - |

| HashSet         | abcde(...)wxyza [27] | 369.700 ns | 4.0918 ns |  5.7362 ns | 368.7694 ns |    6 | 0.6270 |    1312 B |
| Contains        | abcde(...)wxyza [27] | 280.453 ns | 2.1801 ns |  3.0563 ns | 280.0419 ns |    5 | 0.6461 |    1352 B |
| List            | abcde(...)wxyza [27] | 224.909 ns | 8.2141 ns | 12.0402 ns | 220.0334 ns |    4 | 0.1183 |     248 B |
| CustomBitVector | abcde(...)wxyza [27] |  21.393 ns | 0.7509 ns |  1.0770 ns |  21.4190 ns |    3 |      - |         - |
| Stackalloc      | abcde(...)wxyza [27] |  20.646 ns | 0.1229 ns |  0.1724 ns |  20.6686 ns |    2 |      - |         - |
| BitVector32     | abcde(...)wxyza [27] |  20.444 ns | 0.1798 ns |  0.2692 ns |  20.3741 ns |    2 |      - |         - |
| BitMask         | abcde(...)wxyza [27] |  17.017 ns | 0.7435 ns |  1.1128 ns |  16.9258 ns |    1 |      - |         - |

| HashSet         | abcd(...)zzzz [1026] | 365.512 ns | 3.3785 ns |  4.6246 ns | 364.4939 ns |    6 | 0.6270 |    1312 B |
| Contains        | abcd(...)zzzz [1026] | 279.786 ns | 2.2766 ns |  3.1915 ns | 278.6735 ns |    5 | 0.6461 |    1352 B |
| List            | abcd(...)zzzz [1026] | 218.945 ns | 1.2536 ns |  1.7979 ns | 218.7445 ns |    4 | 0.1185 |     248 B |
| BitVector32     | abcd(...)zzzz [1026] |  20.991 ns | 0.1500 ns |  0.2199 ns |  20.9284 ns |    3 |      - |         - |
| CustomBitVector | abcd(...)zzzz [1026] |  19.588 ns | 0.3486 ns |  0.5000 ns |  19.3723 ns |    2 |      - |         - |
| Stackalloc      | abcd(...)zzzz [1026] |  14.739 ns | 0.0827 ns |  0.1186 ns |  14.7700 ns |    1 |      - |         - |
| BitMask         | abcd(...)zzzz [1026] |  14.573 ns | 0.0690 ns |  0.0944 ns |  14.5857 ns |    1 |      - |         - |
