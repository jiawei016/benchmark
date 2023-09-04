```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host] : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|                   Method |    N |     Mean |    Error |   StdDev | Ratio | RatioSD |      Gen0 | Allocated | Alloc Ratio |
|------------------------- |----- |---------:|---------:|---------:|------:|--------:|----------:|----------:|------------:|
|        JsonToJObjectTest | 1000 | 23.55 ms | 0.470 ms | 1.378 ms |  1.52 |    0.08 | 6812.5000 |  20.42 MB |        2.38 |
|         JsonToObjectTest | 1000 | 15.60 ms | 0.262 ms | 0.269 ms |  1.00 |    0.00 | 2843.7500 |   8.57 MB |        1.00 |
| JsonToJsonSerializerTest | 1000 |       NA |       NA |       NA |     ? |       ? |        NA |        NA |           ? |

Benchmarks with issues:
  SerializationBenchmark.JsonToJsonSerializerTest: InProcess(Toolchain=InProcessEmitToolchain) [N=1000]
