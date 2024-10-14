namespace Algo.Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.SlowestToFastest)]
[RankColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
public class DuplicateInStringBenchmarks
{
    public string[] Params =>
    [
        "abcdefghij",
        "hellohe",
        "aabbccddeeffgghhiijj",
        "aabb",
        "abcde" + new string('f', 994)
    ];

    [ParamsSource(nameof(Params))]
    public string Input;

    [Benchmark]
    public char GetFirstDuplicateLetter_SimpleLoops()
    {
        var result = StringDuplicateSolver.GetFirstDuplicateLetter_SimpleLoops(Input);

        return result;
    }

    [Benchmark]
    public char GetFirstDuplicateLetter_ArrayWithCounts()
    {
        var result = StringDuplicateSolver.GetFirstDuplicateLetter_ArrayWithCounts(Input);

        return result;
    }

    [Benchmark]
    public char GetFirstDuplicateLetter_HashSets()
    {
        var result = StringDuplicateSolver.GetFirstDuplicateLetter_HashSets(Input);

        return result;
    }
}
