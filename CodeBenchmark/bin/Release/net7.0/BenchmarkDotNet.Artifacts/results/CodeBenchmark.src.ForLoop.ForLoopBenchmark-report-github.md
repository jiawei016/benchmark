```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                               Method |     N |          Mean |        Error |        StdDev |        Median | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|------------------------------------- |------ |--------------:|-------------:|--------------:|--------------:|------:|--------:|-------:|----------:|------------:|
|                       **RegularForLoop** |   **100** |      **77.33 ns** |     **1.517 ns** |      **1.806 ns** |      **77.19 ns** |  **1.00** |    **0.00** |      **-** |         **-** |          **NA** |
|                          ForEachLoop |   100 |      63.76 ns |     0.963 ns |      0.900 ns |      63.56 ns |  0.82 |    0.02 |      - |         - |          NA |
|                        WithIndexLoop |   100 |   1,595.91 ns |    31.688 ns |     60.290 ns |   1,598.16 ns | 20.82 |    0.92 | 0.0343 |     112 B |          NA |
|          WithIndexCachedDelegateLoop |   100 |   1,700.37 ns |    73.099 ns |    206.176 ns |   1,633.19 ns | 21.37 |    2.16 | 0.0343 |     112 B |          NA |
|                WithIndexIteratorLoop |   100 |   1,420.05 ns |    33.990 ns |     94.186 ns |   1,411.30 ns | 17.42 |    1.24 | 0.0305 |      96 B |          NA |
|        WithIndexCustomEnumeratorLoop |   100 |     614.56 ns |    12.239 ns |     31.153 ns |     611.43 ns |  7.94 |    0.43 | 0.0095 |      32 B |          NA |
| WithIndexSpecificEnumeratorLoopArray |   100 |      78.05 ns |     1.621 ns |      4.491 ns |      76.78 ns |  1.02 |    0.07 |      - |         - |          NA |
|                   RegularForLoopList |   100 |      90.75 ns |     2.660 ns |      7.460 ns |      89.65 ns |  1.13 |    0.06 |      - |         - |          NA |
|                      ForEachLoopList |   100 |     187.22 ns |     5.248 ns |     14.802 ns |     184.93 ns |  2.51 |    0.17 |      - |         - |          NA |
|                    WithIndexLoopList |   100 |   1,755.53 ns |    34.536 ns |     62.276 ns |   1,770.97 ns | 22.56 |    0.74 | 0.0381 |     120 B |          NA |
|      WithIndexCachedDelegateLoopList |   100 |   1,758.31 ns |    34.831 ns |     60.081 ns |   1,746.13 ns | 22.72 |    1.09 | 0.0381 |     120 B |          NA |
|            WithIndexIteratorLoopList |   100 |   1,514.86 ns |    30.213 ns |     61.716 ns |   1,500.30 ns | 19.45 |    1.09 | 0.0324 |     104 B |          NA |
|    WithIndexCustomEnumeratorLoopList |   100 |     860.55 ns |    12.991 ns |     10.848 ns |     862.32 ns | 11.11 |    0.26 | 0.0124 |      40 B |          NA |
|  WithIndexSpecificEnumeratorLoopList |   100 |     254.82 ns |     4.870 ns |      5.413 ns |     253.84 ns |  3.30 |    0.11 |      - |         - |          NA |
|                                      |       |               |              |               |               |       |         |        |           |             |
|                       **RegularForLoop** |  **1000** |     **657.03 ns** |    **12.901 ns** |     **20.085 ns** |     **653.21 ns** |  **1.00** |    **0.00** |      **-** |         **-** |          **NA** |
|                          ForEachLoop |  1000 |     647.72 ns |     8.298 ns |      7.356 ns |     649.15 ns |  0.98 |    0.04 |      - |         - |          NA |
|                        WithIndexLoop |  1000 |  14,245.36 ns |   268.636 ns |    358.622 ns |  14,200.87 ns | 21.74 |    0.83 | 0.0305 |     112 B |          NA |
|          WithIndexCachedDelegateLoop |  1000 |  17,346.33 ns |   410.076 ns |  1,176.585 ns |  17,360.84 ns | 26.71 |    1.87 | 0.0305 |     112 B |          NA |
|                WithIndexIteratorLoop |  1000 |  13,500.04 ns |   269.657 ns |    591.903 ns |  13,438.43 ns | 20.69 |    1.27 | 0.0305 |      96 B |          NA |
|        WithIndexCustomEnumeratorLoop |  1000 |   5,785.94 ns |   114.862 ns |    224.029 ns |   5,771.47 ns |  8.82 |    0.43 | 0.0076 |      32 B |          NA |
| WithIndexSpecificEnumeratorLoopArray |  1000 |     718.45 ns |    18.692 ns |     53.631 ns |     704.72 ns |  1.08 |    0.06 |      - |         - |          NA |
|                   RegularForLoopList |  1000 |     749.28 ns |    14.897 ns |     40.275 ns |     738.41 ns |  1.16 |    0.07 |      - |         - |          NA |
|                      ForEachLoopList |  1000 |   1,643.38 ns |    32.064 ns |     28.424 ns |   1,633.38 ns |  2.49 |    0.09 |      - |         - |          NA |
|                    WithIndexLoopList |  1000 |  17,602.70 ns |   338.431 ns |    660.083 ns |  17,461.90 ns | 26.76 |    1.26 | 0.0305 |     120 B |          NA |
|      WithIndexCachedDelegateLoopList |  1000 |  18,804.48 ns |   644.913 ns |  1,829.510 ns |  18,391.84 ns | 28.83 |    2.61 | 0.0305 |     120 B |          NA |
|            WithIndexIteratorLoopList |  1000 |  15,715.13 ns |   312.558 ns |    778.378 ns |  15,620.75 ns | 24.19 |    1.48 | 0.0305 |     104 B |          NA |
|    WithIndexCustomEnumeratorLoopList |  1000 |   8,797.96 ns |   175.826 ns |    146.823 ns |   8,788.24 ns | 13.32 |    0.57 |      - |      40 B |          NA |
|  WithIndexSpecificEnumeratorLoopList |  1000 |   2,534.55 ns |    50.710 ns |    115.493 ns |   2,525.02 ns |  3.93 |    0.22 |      - |         - |          NA |
|                                      |       |               |              |               |               |       |         |        |           |             |
|                       **RegularForLoop** | **10000** |   **6,726.42 ns** |   **134.103 ns** |    **238.367 ns** |   **6,684.83 ns** |  **1.00** |    **0.00** |      **-** |         **-** |          **NA** |
|                          ForEachLoop | 10000 |   6,627.69 ns |   122.753 ns |    114.824 ns |   6,605.68 ns |  0.99 |    0.04 |      - |         - |          NA |
|                        WithIndexLoop | 10000 | 140,944.79 ns | 2,662.243 ns |  3,461.668 ns | 142,400.78 ns | 20.96 |    1.08 |      - |     112 B |          NA |
|          WithIndexCachedDelegateLoop | 10000 | 143,288.85 ns | 2,710.414 ns |  5,023.927 ns | 142,532.57 ns | 21.33 |    1.14 |      - |     112 B |          NA |
|                WithIndexIteratorLoop | 10000 | 120,480.78 ns | 2,384.377 ns |  3,850.325 ns | 119,860.03 ns | 17.94 |    0.89 |      - |      96 B |          NA |
|        WithIndexCustomEnumeratorLoop | 10000 |  52,424.61 ns | 1,040.356 ns |  1,524.940 ns |  52,140.59 ns |  7.78 |    0.42 |      - |      32 B |          NA |
| WithIndexSpecificEnumeratorLoopArray | 10000 |   6,449.38 ns |   128.530 ns |    231.766 ns |   6,357.83 ns |  0.96 |    0.06 |      - |         - |          NA |
|                   RegularForLoopList | 10000 |   7,830.14 ns |   173.702 ns |    512.164 ns |   7,691.15 ns |  1.15 |    0.10 |      - |         - |          NA |
|                      ForEachLoopList | 10000 |  13,832.38 ns |   271.136 ns |    699.889 ns |  13,732.38 ns |  2.06 |    0.13 |      - |         - |          NA |
|                    WithIndexLoopList | 10000 | 179,070.07 ns | 3,546.569 ns |  9,588.355 ns | 176,864.86 ns | 26.35 |    1.48 |      - |     120 B |          NA |
|      WithIndexCachedDelegateLoopList | 10000 | 180,069.34 ns | 6,794.487 ns | 19,163.970 ns | 174,116.60 ns | 28.20 |    3.53 |      - |     120 B |          NA |
|            WithIndexIteratorLoopList | 10000 | 153,769.39 ns | 3,675.223 ns | 10,366.033 ns | 152,507.68 ns | 22.37 |    1.51 |      - |     104 B |          NA |
|    WithIndexCustomEnumeratorLoopList | 10000 |  95,783.99 ns | 2,919.935 ns |  8,283.369 ns |  92,951.98 ns | 14.20 |    1.38 |      - |      40 B |          NA |
|  WithIndexSpecificEnumeratorLoopList | 10000 |  25,815.60 ns |   561.402 ns |  1,601.712 ns |  25,719.14 ns |  3.82 |    0.28 |      - |         - |          NA |
