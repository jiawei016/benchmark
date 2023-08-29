```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                  Method |   N | Mean | Error | Ratio | RatioSD | Alloc Ratio |
|------------------------ |---- |-----:|------:|------:|--------:|------------:|
|       JsonToJObjectTest | 100 |   NA |    NA |     ? |       ? |           ? |
|        JsonToObjectTest | 100 |   NA |    NA |     ? |       ? |           ? |
|         XmlToObjectTest | 100 |   NA |    NA |     ? |       ? |           ? |
| XmlPrepTimeIncludedTest | 100 |   NA |    NA |     ? |       ? |           ? |
| XmlPrepTimeExcludedTest | 100 |   NA |    NA |     ? |       ? |           ? |
|    ProtoBufToObjectTest | 100 |   NA |    NA |     ? |       ? |           ? |

Benchmarks with issues:
  SerializationBenchmark.JsonToJObjectTest: DefaultJob [N=100]
  SerializationBenchmark.JsonToObjectTest: DefaultJob [N=100]
  SerializationBenchmark.XmlToObjectTest: DefaultJob [N=100]
  SerializationBenchmark.XmlPrepTimeIncludedTest: DefaultJob [N=100]
  SerializationBenchmark.XmlPrepTimeExcludedTest: DefaultJob [N=100]
  SerializationBenchmark.ProtoBufToObjectTest: DefaultJob [N=100]
