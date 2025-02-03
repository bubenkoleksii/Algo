using System.Collections.Frozen;
using System.Text.RegularExpressions;

namespace Algo.Solvers;

// Given the string str, determine if it can be printed using letters from only one row of the keyboard.

// Keyboard row 1: qwertyuiop Keyboard row 2: asdfghjkl Keyboard row 3: zxcvbnm

// Each string also includes the uppercase letters of the corresponding letters in the string (qwertyuiop also has QWERTYUIOP)

// 1 <= str.Length <= 1e3 str[i] = a-zA-Z

public static partial class KeyboardRowSolver
{
    // Time complexity: O(n^2)
    // Space complexity: O(1)
    public static bool RowIdLoop(string str)
    {
        if (str.Length <= 1)
            return true;

        string[] keyboardRows = [
            "qwertyuiop",
            "asdfghjkl",
            "zxcvbnm"
        ];

        var firstCharRowId = GetRowId(str[0], keyboardRows);
        for (var i = 1; i < str.Length; i++)
        {
            var rowId = GetRowId(str[i], keyboardRows);

            if (rowId != firstCharRowId)
                return false;
        }

        return true;
    }

    // Time complexity: O(n^2), where n is unique characters
    // Space complexity: O(n)
    public static bool RowIdLoopDistinct(string str)
    {
        if (str.Length <= 1)
            return true;

        string[] keyboardRows = [
            "qwertyuiop",
            "asdfghjkl",
            "zxcvbnm"
        ];

        var uniqueChars = new HashSet<char>(str, new CaseInsensitiveCharComparer());

        var firstCharRowId = GetRowId(uniqueChars.First(), keyboardRows);
        foreach (var @char in uniqueChars)
        {
            var rowId = GetRowId(@char, keyboardRows);

            if (rowId != firstCharRowId)
                return false;
        }

        return true;
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public static bool RowIdLoopHashSet(string str)
    {
        if (str.Length <= 1)
            return true;

        HashSet<char>[] keyboardRowsHashSets = [
            new HashSet<char>("qwertyuiopQWERTYUIOP"),
            new HashSet<char>("asdfghjklASDFGHJKL"),
            new HashSet<char>("zxcvbnmZXCVBNM"),
        ];

        var firstCharRowId = GetRowIdHashSet(str[0], keyboardRowsHashSets);
        for (var i = 1; i < str.Length; i++)
        {
            var rowId = GetRowIdHashSet(str[i], keyboardRowsHashSets);

            if (rowId != firstCharRowId)
                return false;
        }

        return true;
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public static bool RowIdLoopFrozenSet(string str)
    {
        if (str.Length <= 1)
            return true;

        FrozenSet<char>[] keyboardRowsFrozenSets = [
            new HashSet<char>("qwertyuiopQWERTYUIOP").ToFrozenSet(),
            new HashSet<char>("asdfghjklASDFGHJKL").ToFrozenSet(),
            new HashSet<char>("zxcvbnmZXCVBNM").ToFrozenSet(),
        ];

        var firstCharRowId = GetRowIdFrozenSet(str[0], keyboardRowsFrozenSets);
        for (var i = 1; i < str.Length; i++)
        {
            var rowId = GetRowIdFrozenSet(str[i], keyboardRowsFrozenSets);

            if (rowId != firstCharRowId)
                return false;
        }

        return true;
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public static bool Regex(string str)
    {
        if (str.Length <= 1)
            return true;

        return KeyboardRowRegex().IsMatch(str);
    }

    static int GetRowId(char @char, string[] keyboardRows)
    {
        for (var i = 0; i < keyboardRows.Length; i++)
        {
            if (keyboardRows[i].Contains(@char, StringComparison.OrdinalIgnoreCase))
                return i;
        }

        return -1;
    }

    static int GetRowIdHashSet(char @char, HashSet<char>[] keyboardRowsHashSets)
    {
        for (var i = 0; i < keyboardRowsHashSets.Length; i++)
        {
            if (keyboardRowsHashSets[i].Contains(@char))
                return i;
        }

        return -1;
    }

    static int GetRowIdFrozenSet(char @char, FrozenSet<char>[] keyboardRowsFrozenSets)
    {
        for (var i = 0; i < keyboardRowsFrozenSets.Length; i++)
        {
            if (keyboardRowsFrozenSets[i].Contains(@char))
                return i;
        }

        return -1;
    }

    [GeneratedRegex("^?:([qwertyuiop]+|[asdfghjkl]+|[zxcvbnm]+)$", RegexOptions.IgnoreCase)]
    private static partial Regex KeyboardRowRegex();
}

class CaseInsensitiveCharComparer : IEqualityComparer<char>
{
    public bool Equals(char x, char y) => char.ToLower(x) == char.ToLower(y);

    public int GetHashCode(char obj) => char.ToLower(obj).GetHashCode();
}