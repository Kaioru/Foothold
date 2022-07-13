using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Json;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using Foothold.Benchmarks;

var config = new ManualConfig()
        .WithOptions(ConfigOptions.DisableOptimizationsValidator)
        .AddValidator(JitOptimizationsValidator.DontFailOnError)
        .AddLogger(ConsoleLogger.Default)
        .AddColumnProvider(DefaultColumnProviders.Instance)
        .AddExporter(JsonExporter.Brief)
        .AddExporter(MarkdownExporter.GitHub);

BenchmarkRunner.Run<FindFootholdClosestBenchmarks>(config);
BenchmarkRunner.Run<FindFootholdBelowBenchmarks>(config);
BenchmarkRunner.Run<FindFootholdUnderneathBenchmarks>(config);