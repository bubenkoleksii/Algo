using System.Text.RegularExpressions;

namespace Algo.Solvers;

//Given a string str of any characters, return the sequence of each character.
//The sequence consists of N consecutive identical characters and is interrupted by another character.
//The string can contain several sequences for the same character.

//0 <= str.Length <= 10000
//1 <= N <= str.Length

//Input: ""
//Output: []

//Input: "ab"
//Output: [('a', 1), ('b', 1)]

//Input: "aba"
//Output: [('a', 1), ('b', 1), ('a', 1)]

//Input: "abba"
//Output: [('a', 1), ('b', 2), ('a', 1)]

public static partial class RepeatedCharactersSolver
{
    private static readonly Regex oneOrMoreCharsRegex = OneOrMoreCharsRegex();

    // Time complexity: O(n)
    // Space complexity: O(n)
    public static List<(char Character, int Count)> Counter(string input)
    {
        if (string.IsNullOrEmpty(input))
            return [];

        if (input.Length == 1)
            return [(input[0], 1)];

        var result = new List<(char Character, int Count)>();

        char previousChar = input[0];
        var charCounter = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == previousChar)
            {
                charCounter++;
            }
            else
            {
                result.Add((previousChar, charCounter));
                charCounter = 1;
            }

            if (i == input.Length - 1)
            {
                result.Add((input[i], charCounter));
                break;
            }

            previousChar = input[i];
        }

        return result;
    }

    // Time Complexity: O(n), where n is the length of the input string.
    // Space Complexity: O(m), where m is the number of matches found by the regex.
    public static List<(char Character, int Count)> Regex(string input)
    {
        var result = new List<(char Character, int Count)>();

        var matches = oneOrMoreCharsRegex.Matches(input);

        foreach (Match match in matches)
            result.Add((match.Groups[1].Value[0], match.Length));

        return result;
    }

    [GeneratedRegex(@"(.)\1*")]
    public static partial Regex OneOrMoreCharsRegex();
}
