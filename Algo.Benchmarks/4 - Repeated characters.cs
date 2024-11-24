namespace Algo.Benchmarks;

[MediumRunJob]
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.SlowestToFastest)]
[RankColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
[MarkdownExporter]
[HideColumns("Error", "StdDev", "Median", "Gen0")]
public class RepeatedCharactersBenchmarks
{
    public string[] Params =>
    [
        "abba",
        "aaabbbcccaaa",
        string.Concat(Enumerable.Repeat("aa bb ", 83)) + "aa",
        new string('a', 200) + new string('b', 150) + new string('c', 150)
    ];

    [ParamsSource(nameof(Params))]
    public string Input;

    [Benchmark]
    public List<(char, int)> Counter()
    {
        var res = RepeatedCharactersSolver.Counter(Input);
        return res;
    }

    [Benchmark]
    public List<(char, int)> Regex()
    {
        var res = RepeatedCharactersSolver.Regex(Input);
        return res;
    }
}
