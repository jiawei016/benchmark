```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                  Method |   N |         Mean |       Error |      StdDev |   Gen0 | Allocated |
|------------------------ |---- |-------------:|------------:|------------:|-------:|----------:|
|       TestStringBuilder | 100 |   1,553.8 ns |    24.74 ns |    25.41 ns | 1.1959 |    3752 B |
|        TestStringConcat | 100 |   1,848.1 ns |    35.33 ns |    45.94 ns | 2.7027 |    8480 B |
|  TestStringPlusOperator | 100 |   3,922.7 ns |    78.11 ns |   150.48 ns | 7.5607 |   23736 B |
| TestStringInterpolation | 100 |   2,573.4 ns |    51.33 ns |    89.91 ns | 2.7008 |    8480 B |
|  TestStringStringFormat | 100 |   6,163.0 ns |   122.40 ns |   183.20 ns | 2.7008 |    8480 B |
|       TestStringReplace | 100 |     860.7 ns |    17.04 ns |    28.47 ns |      - |         - |
|         TestStringRegex | 100 | 144,159.9 ns | 2,750.09 ns | 3,671.29 ns | 3.4180 |   11200 B |
