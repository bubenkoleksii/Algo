namespace Algo.Benchmarks;

[LongRunJob]
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.SlowestToFastest)]
[RankColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
public class LongPalindromeBenchmarks
{
    public ulong[] Params =>
    [
        121UL,
        100001UL,
        12345_6_54321UL,
        184467440_66_044764481UL,

        100010UL,
        18446744_0_66_1_44764481UL,
        (ulong)1e19,
        ulong.MaxValue
    ];

    [ParamsSource(nameof(Params))]
    public ulong Input;

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