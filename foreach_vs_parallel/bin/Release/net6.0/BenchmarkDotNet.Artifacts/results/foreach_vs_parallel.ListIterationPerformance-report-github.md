``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.630 (20H2/October2020Update)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|              Method | count |       Mean |    Error |   StdDev |        Min |        Max |  Gen 0 |  Gen 1 | Allocated |
|-------------------- |------ |-----------:|---------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
|  **ForeachPerformance** |    **10** |   **286.5 ns** |  **0.89 ns** |  **0.84 ns** |   **285.1 ns** |   **287.8 ns** | **0.0048** |      **-** |      **40 B** |
| ParallelPerformance |    10 | 2,942.3 ns | 58.27 ns | 79.76 ns | 2,783.4 ns | 3,043.9 ns | 2.1133 | 0.0458 |  15,893 B |
|  **ForeachPerformance** |    **20** |   **576.2 ns** | **11.26 ns** | **12.97 ns** |   **556.0 ns** |   **603.0 ns** | **0.0048** |      **-** |      **40 B** |
| ParallelPerformance |    20 | 3,862.0 ns | 55.73 ns | 52.13 ns | 3,781.3 ns | 3,952.3 ns | 2.5291 | 0.0610 |  18,282 B |
