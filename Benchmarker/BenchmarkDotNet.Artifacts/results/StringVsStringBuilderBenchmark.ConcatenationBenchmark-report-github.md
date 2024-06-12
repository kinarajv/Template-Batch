```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3593/23H2/2023Update/SunValley3)
AMD Ryzen 9 5900HS with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.206
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2


```
| Method                     | NumIterations | Mean             | Error           | StdDev          | Median           | Gen0        | Gen1        | Gen2        | Allocated     |
|--------------------------- |-------------- |-----------------:|----------------:|----------------:|-----------------:|------------:|------------:|------------:|--------------:|
| **StringConcatenation**        | **10**            |         **212.5 ns** |         **8.63 ns** |        **25.31 ns** |         **208.8 ns** |      **0.1950** |           **-** |           **-** |       **1.59 KB** |
| StringBuilderConcatenation | 10            |         266.0 ns |         9.50 ns |        27.72 ns |         263.8 ns |      0.1383 |           - |           - |       1.13 KB |
| **StringConcatenation**        | **1000**          |   **1,047,718.6 ns** |    **50,446.64 ns** |   **146,354.84 ns** |     **987,389.7 ns** |   **1554.6875** |     **91.7969** |           **-** |   **12732.38 KB** |
| StringBuilderConcatenation | 1000          |       7,763.5 ns |       294.02 ns |       862.32 ns |       7,556.8 ns |      7.0724 |      0.5875 |           - |      57.81 KB |
| **StringConcatenation**        | **10000**         | **125,608,435.4 ns** | **2,420,279.94 ns** | **5,891,295.87 ns** | **124,624,330.0 ns** | **374400.0000** | **360400.0000** | **358400.0000** | **1270019.97 KB** |
| StringBuilderConcatenation | 10000         |     224,214.5 ns |     4,448.71 ns |     8,464.13 ns |     224,906.4 ns |     76.9043 |     76.9043 |     76.9043 |     521.78 KB |
