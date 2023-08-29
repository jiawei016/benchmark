```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                               Method |     N |          Mean |        Error |       StdDev |        Median | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|------------------------------------- |------ |--------------:|-------------:|-------------:|--------------:|------:|--------:|-------:|----------:|------------:|
|                       **RegularForLoop** |   **100** |      **77.90 ns** |     **1.067 ns** |     **0.833 ns** |      **77.78 ns** |  **1.00** |    **0.00** |      **-** |         **-** |          **NA** |
|                          ForEachLoop |   100 |      66.95 ns |     1.373 ns |     2.742 ns |      66.53 ns |  0.85 |    0.03 |      - |         - |          NA |
|                        WithIndexLoop |   100 |   1,767.45 ns |    50.998 ns |   147.954 ns |   1,741.54 ns | 21.29 |    1.81 | 0.0343 |     112 B |          NA |
|          WithIndexCachedDelegateLoop |   100 |   1,722.56 ns |    43.270 ns |   123.453 ns |   1,697.03 ns | 22.17 |    1.37 | 0.0343 |     112 B |          NA |
|                WithIndexIteratorLoop |   100 |   1,416.06 ns |    32.128 ns |    92.697 ns |   1,393.37 ns | 18.35 |    1.00 | 0.0305 |      96 B |          NA |
|        WithIndexCustomEnumeratorLoop |   100 |     578.79 ns |    11.622 ns |    19.417 ns |     575.91 ns |  7.41 |    0.25 | 0.0095 |      32 B |          NA |
| WithIndexSpecificEnumeratorLoopArray |   100 |      67.06 ns |     0.694 ns |     0.542 ns |      67.27 ns |  0.86 |    0.01 |      - |         - |          NA |
|                   RegularForLoopList |   100 |      76.38 ns |     1.522 ns |     1.495 ns |      75.68 ns |  0.98 |    0.02 |      - |         - |          NA |
|                      ForEachLoopList |   100 |     158.69 ns |     1.847 ns |     1.542 ns |     158.21 ns |  2.04 |    0.03 |      - |         - |          NA |
|                    WithIndexLoopList |   100 |   1,688.07 ns |    33.157 ns |    52.591 ns |   1,678.06 ns | 21.79 |    0.72 | 0.0381 |     120 B |          NA |
|      WithIndexCachedDelegateLoopList |   100 |   1,753.97 ns |    34.771 ns |    77.770 ns |   1,753.54 ns | 22.77 |    1.05 | 0.0381 |     120 B |          NA |
|            WithIndexIteratorLoopList |   100 |   1,461.45 ns |    25.308 ns |    49.955 ns |   1,454.31 ns | 18.86 |    0.38 | 0.0324 |     104 B |          NA |
|    WithIndexCustomEnumeratorLoopList |   100 |     834.79 ns |    16.406 ns |    15.347 ns |     838.74 ns | 10.73 |    0.19 | 0.0124 |      40 B |          NA |
|  WithIndexSpecificEnumeratorLoopList |   100 |     242.43 ns |     4.731 ns |     4.858 ns |     240.46 ns |  3.11 |    0.08 |      - |         - |          NA |
|                                      |       |               |              |              |               |       |         |        |           |             |
|                       **RegularForLoop** |  **1000** |     **652.79 ns** |    **13.106 ns** |    **30.893 ns** |     **648.06 ns** |  **1.00** |    **0.00** |      **-** |         **-** |          **NA** |
|                          ForEachLoop |  1000 |     610.57 ns |    12.253 ns |    21.781 ns |     609.39 ns |  0.94 |    0.06 |      - |         - |          NA |
|                        WithIndexLoop |  1000 |  13,803.51 ns |   182.097 ns |   161.424 ns |  13,775.58 ns | 21.77 |    1.13 | 0.0305 |     112 B |          NA |
|          WithIndexCachedDelegateLoop |  1000 |  13,764.58 ns |   265.651 ns |   248.490 ns |  13,717.83 ns | 21.72 |    0.96 | 0.0305 |     112 B |          NA |
|                WithIndexIteratorLoop |  1000 |  11,516.34 ns |   169.906 ns |   141.879 ns |  11,510.42 ns | 18.15 |    0.93 | 0.0305 |      96 B |          NA |
|        WithIndexCustomEnumeratorLoop |  1000 |   5,149.56 ns |   101.720 ns |   216.774 ns |   5,084.07 ns |  7.92 |    0.54 | 0.0076 |      32 B |          NA |
| WithIndexSpecificEnumeratorLoopArray |  1000 |     617.15 ns |    11.923 ns |    15.079 ns |     613.96 ns |  0.96 |    0.06 |      - |         - |          NA |
|                   RegularForLoopList |  1000 |     686.95 ns |    10.807 ns |     9.580 ns |     685.23 ns |  1.08 |    0.06 |      - |         - |          NA |
|                      ForEachLoopList |  1000 |   1,518.85 ns |    24.790 ns |    23.188 ns |   1,512.98 ns |  2.40 |    0.11 |      - |         - |          NA |
|                    WithIndexLoopList |  1000 |  19,565.97 ns | 1,175.301 ns | 3,217.368 ns |  18,716.29 ns | 30.21 |    4.64 | 0.0305 |     120 B |          NA |
|      WithIndexCachedDelegateLoopList |  1000 |  17,702.89 ns |   353.087 ns |   752.456 ns |  17,647.49 ns | 27.20 |    1.68 | 0.0305 |     120 B |          NA |
|            WithIndexIteratorLoopList |  1000 |  14,606.60 ns |   276.442 ns |   329.084 ns |  14,613.66 ns | 22.76 |    1.19 | 0.0305 |     104 B |          NA |
|    WithIndexCustomEnumeratorLoopList |  1000 |   8,480.43 ns |   169.604 ns |   201.902 ns |   8,399.44 ns | 13.21 |    0.65 |      - |      40 B |          NA |
|  WithIndexSpecificEnumeratorLoopList |  1000 |   2,408.52 ns |    26.978 ns |    25.235 ns |   2,403.47 ns |  3.80 |    0.17 |      - |         - |          NA |
|                                      |       |               |              |              |               |       |         |        |           |             |
|                       **RegularForLoop** | **10000** |   **6,398.53 ns** |   **114.912 ns** |   **107.488 ns** |   **6,404.90 ns** |  **1.00** |    **0.00** |      **-** |         **-** |          **NA** |
|                          ForEachLoop | 10000 |   6,298.48 ns |    98.603 ns |    87.409 ns |   6,296.95 ns |  0.98 |    0.02 |      - |         - |          NA |
|                        WithIndexLoop | 10000 | 145,549.08 ns | 2,843.747 ns | 4,672.358 ns | 144,814.37 ns | 22.60 |    0.78 |      - |     112 B |          NA |
|          WithIndexCachedDelegateLoop | 10000 | 145,226.79 ns | 2,888.318 ns | 6,864.393 ns | 144,049.74 ns | 22.53 |    0.60 |      - |     112 B |          NA |
|                WithIndexIteratorLoop | 10000 | 123,716.79 ns | 2,439.387 ns | 6,759.530 ns | 122,198.65 ns | 19.48 |    1.30 |      - |      96 B |          NA |
|        WithIndexCustomEnumeratorLoop | 10000 |  55,135.23 ns | 1,400.458 ns | 3,995.585 ns |  53,723.25 ns |  9.34 |    0.65 |      - |      32 B |          NA |
| WithIndexSpecificEnumeratorLoopArray | 10000 |   6,459.25 ns |   125.359 ns |   139.336 ns |   6,402.98 ns |  1.01 |    0.03 |      - |         - |          NA |
|                   RegularForLoopList | 10000 |   7,750.28 ns |   197.453 ns |   566.529 ns |   7,588.55 ns |  1.17 |    0.09 |      - |         - |          NA |
|                      ForEachLoopList | 10000 |  13,013.85 ns |   213.394 ns |   199.609 ns |  12,945.87 ns |  2.03 |    0.05 |      - |         - |          NA |
|                    WithIndexLoopList | 10000 | 172,154.71 ns | 3,383.725 ns | 5,745.822 ns | 171,249.69 ns | 26.59 |    0.80 |      - |     120 B |          NA |
|      WithIndexCachedDelegateLoopList | 10000 | 164,077.76 ns | 3,269.691 ns | 5,372.196 ns | 164,019.26 ns | 26.10 |    0.84 |      - |     120 B |          NA |
|            WithIndexIteratorLoopList | 10000 | 137,440.11 ns | 2,022.614 ns | 1,891.954 ns | 137,409.29 ns | 21.49 |    0.47 |      - |     104 B |          NA |
|    WithIndexCustomEnumeratorLoopList | 10000 |  82,765.68 ns | 1,500.488 ns | 1,330.143 ns |  82,780.85 ns | 12.92 |    0.25 |      - |      40 B |          NA |
|  WithIndexSpecificEnumeratorLoopList | 10000 |  23,187.50 ns |   455.513 ns |   608.097 ns |  23,234.85 ns |  3.64 |    0.11 |      - |         - |          NA |
