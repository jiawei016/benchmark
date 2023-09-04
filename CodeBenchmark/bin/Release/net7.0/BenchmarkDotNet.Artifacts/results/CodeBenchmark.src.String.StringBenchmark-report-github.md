```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                  Method |   N |         Mean |       Error |       StdDev |       Median |    Gen0 | Allocated |
|------------------------ |---- |-------------:|------------:|-------------:|-------------:|--------:|----------:|
|       TestStringBuilder | 100 |   1,685.6 ns |    37.24 ns |    106.26 ns |   1,679.3 ns |  1.1959 |    3752 B |
|        TestStringConcat | 100 |   2,379.6 ns |   189.84 ns |    547.72 ns |   2,156.4 ns |  2.7008 |    8480 B |
|  TestStringPlusOperator | 100 |   4,456.0 ns |   161.80 ns |    448.36 ns |   4,359.1 ns |  7.5607 |   23736 B |
| TestStringInterpolation | 100 |   3,051.8 ns |   169.62 ns |    492.09 ns |   2,839.5 ns |  2.7008 |    8480 B |
|  TestStringStringFormat | 100 |   6,711.3 ns |   133.04 ns |    239.90 ns |   6,751.8 ns |  2.7008 |    8480 B |
|       TestStringReplace | 100 |     900.9 ns |    17.76 ns |     22.46 ns |     903.5 ns |       - |         - |
|     TestStringSubstring | 100 |           NA |          NA |           NA |           NA |      NA |        NA |
| TestStringSubstringLoop | 100 |  15,371.1 ns |   298.71 ns |    366.84 ns |  15,448.9 ns | 24.4751 |   76800 B |
|         TestStringRegex | 100 | 158,873.7 ns | 3,551.24 ns | 10,359.13 ns | 157,497.2 ns |  3.4180 |   11200 B |

Benchmarks with issues:
  StringBenchmark.TestStringSubstring: DefaultJob [N=100]
