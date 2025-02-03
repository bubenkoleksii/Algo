namespace Algo.Benchmarks.Extensions;

public static partial class StringExtensions
{
    public static string Replicate(this string str, int times) =>
        string.Concat(Enumerable.Repeat(str, times));
}
