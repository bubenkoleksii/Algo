namespace Algo.Benchmarks;

[SimpleJob]
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.SlowestToFastest)]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
public partial class FallingRocksBenchmarks
{
    [ParamsSource(nameof(Data))]
    public string? Test;

    [Benchmark]
    public string Matrix() => FallingRocksSolver.Matrix(Test!);

    [Benchmark]
    public string ColumnsCountStepSb() => FallingRocksSolver.ColumnsCountStepSb(Test!);

    [Benchmark]
    public string ColumnsCountStepCharArr() => FallingRocksSolver.ColumnsCountStepCharArr(Test!);
}
