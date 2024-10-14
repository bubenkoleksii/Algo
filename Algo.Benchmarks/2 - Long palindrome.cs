namespace Algo.Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.SlowestToFastest)]
[RankColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
public class LongPalindromeBenchmarks
{
    public long[] Params =>
    [
            12321,
            1234321,
            12345,
            123456789987654321
    ];

    [ParamsSource(nameof(Params))]
    public long Input;

    [Benchmark]
    public bool Division()
    {
        var res = LongPalindromeSolver.Division(Input);
        return res;
    }

    [Benchmark]
    public bool DivideStrings()
    {
        var res = LongPalindromeSolver.DivideStrings(Input);
        return res;
    }

    [Benchmark]
    public bool ReverseNumber()
    {
        var res = LongPalindromeSolver.ReverseNumber(Input);
        return res;
    }
}