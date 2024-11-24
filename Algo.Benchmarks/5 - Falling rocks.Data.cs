namespace Algo.Benchmarks;

public partial class FallingRocksBenchmarks
{
    public static IEnumerable<string> Data
    {
        get
        {
            yield return "#\r\n ";

            var checkerPattern1 = string.Concat(Enumerable.Repeat("# ", 32));
            var checkerPattern2 = string.Concat(Enumerable.Repeat(" #", 32));

            var checkerPair = checkerPattern1 + Environment.NewLine + checkerPattern2;
            var checker64x64 = string.Join(Environment.NewLine, Enumerable.Repeat(checkerPair, 32));
            yield return checker64x64;

            var empty64x64 = string.Join(Environment.NewLine, Enumerable.Repeat(new string(' ', 64), 64));
            yield return empty64x64;

            var full64x64 = string.Join(Environment.NewLine, Enumerable.Repeat(new string('#', 64), 64));
            yield return full64x64;

            var fullHalf = Enumerable.Repeat(new string('#', 64), 32);
            var emptyHalf = Enumerable.Repeat(new string(' ', 64), 32);
            var halfFullHalfEmpty = string.Join(Environment.NewLine, fullHalf.Concat(emptyHalf));

            yield return halfFullHalfEmpty;
        }
    }
}
