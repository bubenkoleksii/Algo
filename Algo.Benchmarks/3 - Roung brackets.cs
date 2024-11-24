namespace Algo.Benchmarks;

[LongRunJob]
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.SlowestToFastest)]
[RankColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
[MarkdownExporter]
[HideColumns("Error", "StdDev", "Median", "Gen0")]
public class RoundBracketsBenchmarks
{
    public string[] Params
    => [
        "()",
        "(())",
        new string('(', 5000) + new string(')', 5000),
        GeneratePairs(5000),

        "(" + GeneratePairs(4998) + "(",
    ];


    [ParamsSource(nameof(Params))]
    public string Input;

    [Benchmark]
    public bool TwoIdArrays()
    {
        var res = RoundBracketsSolver.TwoIdArrays(Input);
        return res;
    }

    [Benchmark]
    public bool Stack()
    {
        var res = RoundBracketsSolver.Stack(Input);
        return res;
    }

    [Benchmark]
    public bool Counter()
    {
        var res = RoundBracketsSolver.Counter(Input);
        return res;
    }

    private static string GeneratePairs(int n) => string.Join("", Enumerable.Repeat("()", n));
}
