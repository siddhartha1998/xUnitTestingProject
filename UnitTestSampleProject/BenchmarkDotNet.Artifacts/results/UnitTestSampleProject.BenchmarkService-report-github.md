``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1889 (21H2)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.303
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  DefaultJob : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT


```
|                          Method |     Mean |     Error |    StdDev | Rank |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
|-------------------------------- |---------:|----------:|----------:|-----:|---------:|---------:|--------:|----------:|
| ConcatStringsUsingStringBuilder | 4.742 ms | 0.0943 ms | 0.2031 ms |    2 | 234.3750 | 156.2500 | 85.9375 |     15 MB |
|   ConcatStringsUsingGenericList | 4.147 ms | 0.1442 ms | 0.4228 ms |    1 |  39.0625 |  31.2500 | 31.2500 |      9 MB |
