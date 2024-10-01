using Algo.Solvers;
using BenchmarkDotNet.Attributes;

namespace Algo.Benchmarks;

[MemoryDiagnoser]
[LongRunJob]
public class DuplicateInStringBenchmarks
{
    [Benchmark]
    public char GetFirstDuplicateLetter_SimpleLoops()
    {
        char result = char.MinValue;

         List<string> testStrings =
         [
            "ab",
            "abcdefghij",
            "klmnopqrst",
            "uvwxyz",
            "hellohe",
            "character",
            "randomletters",
            "aabbccddeeffgghhiijj",
            "longerdoubleletter",
            "thisisaverylongstringthatexceedstwentycharacters",
            "uniquecharsarefun",
            "xyzxyzxyzxyzxyzxyzxyzxyzxyzxyzxyzxyz",
            "aabb",
            "abcde" + new string('f', 85)
         ];

        foreach (var s in testStrings)
        {
            result = StringDuplicateSolver.GetFirstDuplicateLetter_SimpleLoops(s);
        }

        return result;
    }

    [Benchmark]
    public char GetFirstDuplicateLetter_ArrayWithCounts()
    {
        char result = char.MinValue;

        List<string> testStrings =
        [
           "ab",
            "abcdefghij",
            "klmnopqrst",
            "uvwxyz",
            "hellohe",
            "character",
            "randomletters",
            "aabbccddeeffgghhiijj",
            "longerdoubleletter",
            "thisisaverylongstringthatexceedstwentycharacters",
            "uniquecharsarefun",
            "xyzxyzxyzxyzxyzxyzxyzxyzxyzxyzxyzxyz",
            "aabb",
            "abcde" + new string('f', 85)
        ];

        foreach (var s in testStrings)
        {
            result = StringDuplicateSolver.GetFirstDuplicateLetter_ArrayWithCounts(s);
        }

        return result;
    }

    [Benchmark]
    public char GetFirstDuplicateLetter_HashSets()
    {
        char result = char.MinValue;

        List<string> testStrings =
        [
           "ab",
            "abcdefghij",
            "klmnopqrst",
            "uvwxyz",
            "hellohe",
            "character",
            "randomletters",
            "aabbccddeeffgghhiijj",
            "longerdoubleletter",
            "thisisaverylongstringthatexceedstwentycharacters",
            "uniquecharsarefun",
            "xyzxyzxyzxyzxyzxyzxyzxyzxyzxyzxyzxyz",
            "aabb",
            "abcde" + new string('f', 85)
        ];

        foreach (var s in testStrings)
        {
            result = StringDuplicateSolver.GetFirstDuplicateLetter_HashSets(s);
        }

        return result;
    }
}
