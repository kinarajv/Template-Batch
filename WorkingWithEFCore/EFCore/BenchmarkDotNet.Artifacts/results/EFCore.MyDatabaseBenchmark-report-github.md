```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3085/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900HS with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method       | Mean     | Error    | StdDev   | Gen0   | Gen1   | Allocated |
|------------- |---------:|---------:|---------:|-------:|-------:|----------:|
| IncludeFirst | 67.32 μs | 1.311 μs | 2.191 μs | 5.3711 | 0.2441 |  44.78 KB |
| WhereFirst   | 65.99 μs | 1.312 μs | 1.752 μs | 5.3711 | 0.2441 |  44.78 KB |
