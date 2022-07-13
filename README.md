# Foothold
2D plane geometry benchmarks and experiments for a 2D game

## 🤔 Methods
The current benchmarks tests against:
* [RBush](https://github.com/viceroypenguin/RBush)
* Plain ol' Array

There are plans to benchmark BST and QuadTrees as well.

## 📋 Benchmarks
All benchmarks published on this page is ran on the following specifications.
``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.4 (21F79) [Darwin 21.5.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK=6.0.301
  [Host]     : .NET 6.0.6 (6.0.622.26707), Arm64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), Arm64 RyuJIT
```

### FindFootholdClosest
This method finds the nearest point from a given point. 

Typically used for when finding the nearest spawnpoint in a field.

| Method |              Point |     Mean |    Error |   StdDev | Rank |
|------- |------------------- |---------:|---------:|---------:|-----:|
|  RBush |       Point (0, 0) | 45.64 μs | 0.068 μs | 0.057 μs |    1 |
|  RBush | Point (9000, 9000) | 46.16 μs | 0.372 μs | 0.291 μs |    1 |
|  RBush |   Point (429, 290) | 47.00 μs | 0.839 μs | 0.784 μs |    1 |
|  Array | Point (9000, 9000) | 56.74 μs | 0.050 μs | 0.042 μs |    2 |
|  Array |       Point (0, 0) | 58.02 μs | 0.030 μs | 0.026 μs |    3 |
|  Array |   Point (429, 290) | 58.39 μs | 0.066 μs | 0.051 μs |    3 |

### FindFootholdBelow
This method finds the nearest point, or segment in a straight line down from a given point.

Typically used for finding the line segment (floor) where a falling object will fall onto.

| Method |              Point |         Mean |      Error |     StdDev | Rank |
|------- |------------------- |-------------:|-----------:|-----------:|-----:|
|  RBush | Point (9000, 9000) |     95.84 ns |   0.287 ns |   0.269 ns |    1 |
|  RBush |       Point (0, 0) |    721.77 ns |   8.947 ns |   7.471 ns |    2 |
|  RBush |   Point (429, 290) |    931.71 ns |   2.262 ns |   1.889 ns |    3 |
|  Array | Point (9000, 9000) | 19,159.15 ns |  17.328 ns |  15.361 ns |    4 |
|  Array |   Point (429, 290) | 34,256.11 ns | 102.668 ns |  91.013 ns |    5 |
|  Array |       Point (0, 0) | 40,552.03 ns | 798.794 ns | 784.523 ns |    6 |

### FindFootholdUnderneath
This method finds the point, or segment intersecting a given point.

Typically used for validating player object movements and positioning.

| Method |              Point |        Mean |    Error |   StdDev | Rank |
|------- |------------------- |------------:|---------:|---------:|-----:|
|  RBush | Point (9000, 9000) |    105.6 ns |  0.37 ns |  0.32 ns |    1 |
|  RBush |       Point (0, 0) |    276.6 ns |  0.13 ns |  0.13 ns |    2 |
|  RBush |   Point (429, 298) |    366.1 ns |  0.38 ns |  0.32 ns |    3 |
|  Array | Point (9000, 9000) | 76,319.4 ns | 48.41 ns | 40.42 ns |    4 |
|  Array |   Point (429, 298) | 78,222.4 ns | 48.99 ns | 45.82 ns |    5 |
|  Array |       Point (0, 0) | 78,715.4 ns | 28.76 ns | 26.90 ns |    5 |

## ⭐️ Acknowledgements
* [Matthieu Tran](https://github.com/matthieutran) - making me work on 2d mushroom game at gunpoint. (jk)
* [moe-miho](https://github.com/y785/moe-miho) - the project that inspired this.
