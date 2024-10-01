using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Running;

namespace Algo.Benchmarks;

internal class Program
{
    static void Main(string[] args)
    {
        static ManualConfig configFactory() => ManualConfig
            .CreateMinimumViable()
            .WithArtifactsPath("Artifacts")
            .WithOptions(ConfigOptions.JoinSummary)
            .WithOptions(ConfigOptions.DisableLogFile)
            .AddExporter(MarkdownExporter.Default)
            .AddDiagnoser(MemoryDiagnoser.Default);

        var summary = BenchmarkRunner.Run<DuplicateInStringBenchmarks>(configFactory());
    }
}
