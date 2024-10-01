using Algo.Solvers;

namespace Algo;

internal class Program
{
    static void Main(string[] args)
    {
        #region Find first duplicate letter

        var testCases = new Dictionary<string, char>
        {
            { "aqrmmtak", 'm' },
            { "abcdefgabc", 'a' },
            { "zxyzzxyz", 'z' },
            { "hellohe", 'l' },
            { "character", 'a' },
            { "randomletters", 't' }
        };

        Console.WriteLine("#1 Simple loops");
        foreach (var testCase in testCases)
        {
            var testString = testCase.Key;
            var expected = testCase.Value;

            var result = StringDuplicateSolver.GetFirstDuplicateLetter_SimpleLoops(testString);
            AssertStrings(testString, result, expected);
        }

        Console.WriteLine("\n#2 Array with counts");
        foreach (var testCase in testCases)
        {
            var testString = testCase.Key;
            var expected = testCase.Value;

            var result = StringDuplicateSolver.GetFirstDuplicateLetter_ArrayWithCounts(testString);
            AssertStrings(testString, result, expected);
        }

        Console.WriteLine("\n#3 Hash sets");
        foreach (var testCase in testCases)
        {
            var testString = testCase.Key;
            var expected = testCase.Value;

            var result = StringDuplicateSolver.GetFirstDuplicateLetter_HashSets(testString);
            AssertStrings(testString, result, expected);
        }

        #endregion
    }

    public static void AssertStrings(string testString, char actual, char expected)
    {
        if (actual == expected)
        {
            Console.WriteLine("Test passed");
        }
        else
        {
            Console.WriteLine($"Test string: {testString}");
            Console.WriteLine($"Test failed: expected '{expected}', but got '{actual}'");
            Console.WriteLine();
        }
    }
}
