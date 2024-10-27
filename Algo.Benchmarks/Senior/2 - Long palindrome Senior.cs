using System.Runtime.CompilerServices;

namespace Algo.Benchmarks.Senior;

[MediumRunJob]
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.SlowestToFastest)]
[RankColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
[MarkdownExporter]
[HideColumns("Error", "StdDev", "Median", "Gen0")]
public class LongPalindromeSeniorBenchmarks
{
    [Params(0, 5, (ulong)1e19, 121, 12345_6_54321UL, 184467440_66_044764481UL, 18446744_0_66_1_44764481UL, ulong.MaxValue)]
    public ulong N;

    [Benchmark]
    public bool TwoStringUnoptimized() => LongPalindromeSeniorSolver.TwoStringUnoptimized(N);

    [Benchmark]
    public bool TwoString() => LongPalindromeSeniorSolver.TwoString(N);

    [Benchmark]
    public bool SingleString() => LongPalindromeSeniorSolver.SingleString(N);

    [Benchmark]
    public bool SingleStringSpan() => LongPalindromeSeniorSolver.SingleStringSpan(N);

    [Benchmark]
    public bool SequenceEquals() => LongPalindromeSeniorSolver.SequenceEquals(N);

    [Benchmark]
    public bool LongReverse() => LongPalindromeSeniorSolver.ReverseNumber(N);

    [Benchmark]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool LongReverse_AggressiveInlining()
    {
        if (N != 0 && N % 10 == 0) return false;
        if (N < 10) return true;

        var reverse = 0UL;
        var copy = N;

        while (copy > 0)
        {
            reverse = reverse * 10 + copy % 10;
            copy /= 10;
        }

        return reverse == N;
    }
}
