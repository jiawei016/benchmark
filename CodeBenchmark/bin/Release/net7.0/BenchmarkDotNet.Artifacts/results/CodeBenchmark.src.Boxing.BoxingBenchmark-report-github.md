```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|            Method |    N |        Mean |     Error |     StdDev |    Gen0 | Allocated |
|------------------ |----- |------------:|----------:|-----------:|--------:|----------:|
|  TestingArrayList | 1000 | 2,707.49 μs | 54.129 μs | 142.596 μs | 19.5313 |  63.09 KB |
| TestingObjectList | 1000 | 2,606.00 μs | 51.361 μs |  73.661 μs | 19.5313 |  63.09 KB |
|    TestingIntList | 1000 |    56.36 μs |  1.122 μs |   2.342 μs |  2.6245 |   8.23 KB |
| TestingNumberList | 1000 | 1,183.58 μs | 23.441 μs |  59.664 μs | 33.2031 | 102.17 KB |
