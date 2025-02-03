using Algo.Benchmarks.Extensions;

namespace Algo.Benchmarks;

[SimpleJob]
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.SlowestToFastest)]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
public class PangramBenchmarks
{
    [ParamsSource(nameof(Data))]
    public string? Test;

    [Benchmark]
    public bool OneLiner() => PangramSolver.OneLiner(Test!);

    [Benchmark]
    public bool Counters() => PangramSolver.Counters(Test!);

    [Benchmark(Baseline = true)]
    public bool Mask() => PangramSolver.Mask(Test!);

    [Benchmark]
    public bool Regex() => PangramSolver.Regex(Test!);

    public IEnumerable<string> Data
    {
        get
        {
            yield return "helloworld";
            yield return "thequickbrownfoxjumpsoverthelazydog";
            yield return "abcdefghijklmnopqrstuvwxy".Replicate(times: 40);
            yield return "abcdefghijklmnopqrstuvwxyz".Replicate(times: 40);
            yield return new('x', 1_000);
        }
    }
}
