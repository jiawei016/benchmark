```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                     Method |   N |       Mean |    Error |   StdDev |   Gen0 | Allocated |
|--------------------------- |---- |-----------:|---------:|---------:|-------:|----------:|
|  TestArrayClassDeclaration | 100 | 1,711.9 ns | 33.83 ns | 65.18 ns | 2.1992 |   6.74 KB |
| TestArrayStructDeclaration | 100 | 1,271.2 ns | 24.91 ns | 34.92 ns | 1.4343 |    4.4 KB |
|       TestClassDeclaration | 100 | 1,466.4 ns | 29.36 ns | 33.82 ns | 1.9379 |   5.94 KB |
|      TestStructDeclaration | 100 |   983.2 ns | 18.52 ns | 34.78 ns | 0.9174 |   2.81 KB |
