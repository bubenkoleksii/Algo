namespace Algo.Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.SlowestToFastest)]
[RankColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
public class DuplicateInStringSeniorBenchmarks
{
    public string[] Params
    => [
        "aa",
        "abccbaacz",
        "abcdefghijklmnopqrstuvwxyza",
        "abcdefghijklmnopqrstuvwxyz" + new string('z', 1000),
    ];


    [ParamsSource(nameof(Params))]
    public string Input;

    [Benchmark]
    public char ContainsMethod()
    {
        return StringDuplicateSeniorSolver.Contains(Input);
    }

    [Benchmark]
    public char ListMethod()
    {
        return StringDuplicateSeniorSolver.List(Input);
    }

    [Benchmark]
    public char HashSetMethod()
    {
        return StringDuplicateSeniorSolver.HashSet(Input);
    }

    [Benchmark]
    public char BitMaskMethod()
    {
        return StringDuplicateSeniorSolver.BitMask(Input);
    }

    [Benchmark]
    public char StackallocMethod()
    {
        return StringDuplicateSeniorSolver.Stackalloc(Input);
    }

    [Benchmark]
    public char BitVector32Method()
    {
        return StringDuplicateSeniorSolver.BitVector32(Input);
    }

    [Benchmark]
    public char CustomBitVectorMethod()
    {
        return StringDuplicateSeniorSolver.CustomBitVector(Input);
    }
}
