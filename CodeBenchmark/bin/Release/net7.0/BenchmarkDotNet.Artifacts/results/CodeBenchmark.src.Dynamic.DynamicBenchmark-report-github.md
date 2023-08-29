```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                      Method |   N |        Mean |      Error |     StdDev |      Median |    Gen0 | Allocated |
|---------------------------- |---- |------------:|-----------:|-----------:|------------:|--------:|----------:|
|                   SumOneToN | 100 |    41.61 ns |   0.834 ns |   1.085 ns |    41.51 ns |       - |         - |
|                StringConcat | 100 | 6,534.65 ns | 130.692 ns | 289.605 ns | 6,432.60 ns | 23.3154 |   73160 B |
|         DynamicStringConcat | 100 | 6,923.09 ns | 104.805 ns |  92.906 ns | 6,927.46 ns | 23.3154 |   73160 B |
|                  FormatUser | 100 |   966.72 ns |  17.817 ns |  15.795 ns |   962.02 ns |  1.2741 |    4000 B |
|       DynamicallyFormatUser | 100 | 1,347.15 ns |   8.504 ns |   6.639 ns | 1,349.37 ns |  1.2741 |    4000 B |
|            StructFormatUser | 100 |    40.95 ns |   0.847 ns |   0.793 ns |    40.62 ns |       - |         - |
| StructDynamicallyFormatUser | 100 | 1,502.75 ns |  16.996 ns |  14.192 ns | 1,502.82 ns |  1.2741 |    4000 B |
