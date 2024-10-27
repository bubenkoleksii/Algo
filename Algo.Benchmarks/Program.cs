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

        var summary = BenchmarkRunner.Run<Senior.LongPalindromeSeniorBenchmarks>(configFactory());
    }
}
