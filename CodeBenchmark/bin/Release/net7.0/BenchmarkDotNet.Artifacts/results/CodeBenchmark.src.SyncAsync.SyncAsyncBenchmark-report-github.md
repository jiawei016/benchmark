```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                 Method |    N |       Mean |     Error |    StdDev |     Gen0 | Allocated |
|----------------------- |----- |-----------:|----------:|----------:|---------:|----------:|
|      **TestingSyncMethod** | **1000** |   **4.782 μs** | **0.0955 μs** | **0.2361 μs** |   **7.6447** |  **23.44 KB** |
| TestingSyncAsyncMethod | 1000 |  32.479 μs | 0.6395 μs | 0.9956 μs |  30.3955 |  93.12 KB |
|      TestingTaskMethod | 1000 |  28.917 μs | 0.4963 μs | 0.4399 μs |  30.3955 |  93.12 KB |
|      **TestingSyncMethod** | **5000** |  **19.622 μs** | **0.3877 μs** | **0.6370 μs** |  **38.2385** | **117.19 KB** |
| TestingSyncAsyncMethod | 5000 | 139.807 μs | 2.7357 μs | 5.1383 μs | 152.5879 | 468.12 KB |
|      TestingTaskMethod | 5000 | 124.912 μs | 2.4908 μs | 2.8684 μs | 152.5879 | 468.12 KB |
