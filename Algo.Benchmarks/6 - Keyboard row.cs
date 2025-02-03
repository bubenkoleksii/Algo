namespace Algo.Benchmarks;

[SimpleJob]
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.SlowestToFastest)]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
public class KeyboardRowBenchmarks
{
    public static IEnumerable<string> Data
    {
        get
        {
            yield return "X";
            yield return "hElLoWoRlD";
            yield return new string('X', (int)1e3);
            yield return string.Concat(Enumerable.Repeat("qwertyuiopQWERTYUIOP", 50)) + "M";
        }
    }

    [ParamsSource(nameof(Data))]
    public string Input;

    [Benchmark]
    public bool RowIdLoop()
    {
        var res = KeyboardRowSolver.RowIdLoop(Input);
        return res;
    }

    [Benchmark]
    public bool RowIdLoopDistinct()
    {
        var res = KeyboardRowSolver.RowIdLoopDistinct(Input);
        return res;
    }

    [Benchmark]
    public bool RowIdLoopHashSet()
    {
        var res = KeyboardRowSolver.RowIdLoopHashSet(Input);
        return res;
    }

    [Benchmark]
    public bool RowIdLoopFrozenSet()
    {
        var res = KeyboardRowSolver.RowIdLoopFrozenSet(Input);
        return res;
    }

    [Benchmark]
    public bool Regex()
    {
        var res = KeyboardRowSolver.Regex(Input);
        return res;
    }
}
