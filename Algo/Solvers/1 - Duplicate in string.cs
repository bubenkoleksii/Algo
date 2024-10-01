namespace Algo.Solvers;

// Task: Find first duplicate letter

//- with the string str, return the first letter that is found twice
//- 2 <= str.Length <= 1000
//- only a-z in the string (only lowercase)
//- the string is guaranteed to have a duplicate
public static class StringDuplicateSolver
{
    // Time complexity: O(n^2)
    // Space complexity: O(1)
    public static char GetFirstDuplicateLetter_SimpleLoops(string str)
    {
        var firstDuplicateLetter = char.MinValue;
        var firstDuplicateIndex = int.MaxValue;

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i].Equals(str[j]) && j < firstDuplicateIndex)
                {
                    firstDuplicateLetter = str[i];
                    firstDuplicateIndex = j;

                    break;
                }
            }
        }

        return firstDuplicateLetter;
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public static char GetFirstDuplicateLetter_ArrayWithCounts(string str)
    {
        var counts = new int[26];

        foreach (char c in str)
        {
            var letterIndex = c - 'a';
            counts[letterIndex]++;

            if (counts[letterIndex] == 2)
                return c;
        }

        return char.MinValue;
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public static char GetFirstDuplicateLetter_HashSets(string str)
    {
        var uniqueSet = new HashSet<char>();

        foreach (char c in str)
        {
            if (!uniqueSet.Add(c))
                return c;
        }

        return char.MinValue;
    }
}
