```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3593/23H2/2023Update/SunValley3)
AMD Ryzen 9 5900HS with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.206
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2


```
| Method                        | Mean     | Error     | StdDev    | Rank | Allocated |
|------------------------------ |---------:|----------:|----------:|-----:|----------:|
| BenchmarkStringChanges        | 1.882 ns | 0.0678 ns | 0.0726 ns |    1 |         - |
| BenchmarkStringBuilderChanges | 3.743 ns | 0.1013 ns | 0.1516 ns |    2 |         - |