using System.Text.RegularExpressions;

namespace Algo.Solvers;

//Given the input string, determine if it is a pangram.

//A pangram is a sentence in which each letter of the alphabet is used at least once

// 0 <= input.Length <= 1000 input[i] is [a-z]*

public static partial class PangramSolver
{
    private const int EnglishLettersCount = 26;

    // Time complexity: O(n) * O(26) ≈ O(n)
    // Space complexity: O(1)
    public static bool OneLiner(string input) => input.Distinct().Count() == EnglishLettersCount;

    // Time complexity: O(n) * O(26) ≈ O(n)
    // Space complexity: O(26) ≈ O(1)
    public static bool Counters(string input)
    {
        if (input.Length < 26)
            return false;

        var counters = new byte[26]; // stackalloc

        foreach (var @char in input)
        {
            var index = @char - 'a';
            counters[index]++;
        }

        return !counters.Any(counter => counter == 0);
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public static bool Mask(string input)
    {
        if (input.Length < 26)
            return false;

        var mask = 0;

        foreach (var @char in input)
        {
            var index = @char - 'a';

            mask |= 1 << index;
        }

        return mask == 0b00000011_1111_1111_1111_1111_1111_1111;
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public static bool Regex(string input)
    {
        if (input.Length < 26)
            return false;

        return PangramRegex().IsMatch(input);
    }

    [GeneratedRegex("^(?=.*a)(?=.*b)(?=.*c)(?=.*d)(?=.*e)(?=.*f)(?=.*g)(?=.*h)(?=.*i)(?=.*j)(?=.*k)(?=.*l)(?=.*m)(?=.*n)(?=.*o)(?=.*p)(?=.*q)(?=.*r)(?=.*s)(?=.*t)(?=.*u)(?=.*v)(?=.*w)(?=.*x)(?=.*y)(?=.*z).+$", RegexOptions.IgnoreCase)]
    private static partial Regex PangramRegex();
}
