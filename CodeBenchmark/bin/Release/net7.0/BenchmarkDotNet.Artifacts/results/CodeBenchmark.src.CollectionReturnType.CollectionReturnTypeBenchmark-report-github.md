```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                 Method |    N |     Mean |    Error |   StdDev | Ratio | RatioSD |    Gen0 | Allocated | Alloc Ratio |
|----------------------- |----- |---------:|---------:|---------:|------:|--------:|--------:|----------:|------------:|
|             ListAsList | 1000 | 10.04 μs | 0.170 μs | 0.232 μs |  1.00 |    0.00 | 12.9242 |  39.65 KB |        1.00 |
|            ListAsIList | 1000 | 19.78 μs | 0.373 μs | 0.458 μs |  1.97 |    0.07 | 12.9395 |  39.69 KB |        1.00 |
|      ListAsIEnumerable | 1000 | 19.73 μs | 0.392 μs | 0.550 μs |  1.97 |    0.07 | 12.9395 |  39.69 KB |        1.00 |
|      ListAsICollection | 1000 | 19.40 μs | 0.260 μs | 0.231 μs |  1.93 |    0.04 | 12.9395 |  39.69 KB |        1.00 |
| CollectionAsCollection | 1000 | 26.32 μs | 0.518 μs | 0.554 μs |  2.62 |    0.10 | 12.9395 |  39.71 KB |        1.00 |
|       CollectionToList | 1000 | 16.62 μs | 0.229 μs | 0.203 μs |  1.65 |    0.04 | 15.5029 |  47.54 KB |        1.20 |
|            IListToList | 1000 | 10.89 μs | 0.199 μs | 0.166 μs |  1.08 |    0.01 | 15.5029 |  47.52 KB |        1.20 |
|      IEnumerableToList | 1000 | 10.99 μs | 0.208 μs | 0.214 μs |  1.10 |    0.03 | 15.5029 |  47.52 KB |        1.20 |
|      ICollectionToList | 1000 | 11.09 μs | 0.221 μs | 0.344 μs |  1.11 |    0.04 | 15.5029 |  47.52 KB |        1.20 |
