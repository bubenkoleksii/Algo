namespace Algo.Solvers;

//Given a string str consisting only of the characters ‘(’ and ‘)’, determine if it is a valid bracket sequence.
//A bracket sequence is called correct if the number of open and closed brackets is the same and the correct sequence of nesting and opening/closing brackets is preserved
//0 <= str.Length <= 1000
//str[i] ∈ ( ‘(’;‘)’ )

public static partial class RoundBracketsSolver
{
    // Time complexity:  3 <= O(n + n / 2 ) <= 1_500, n є 2Z, COUNT(open) = COUNT(closed)
    // Space complexity:  4 <= O(2n) <= 2_000, n є 2Z
    public static bool TwoIdArrays(string str)
    {
        if (string.IsNullOrWhiteSpace(str) || str.Length % 2 != 0)
            return false;

        var openBracketsIds = new List<int>(str.Length);
        var closeBracketsIds = new List<int>(str.Length);

        for (var i = 0; i < str.Length; i++)
        {
            if (str[i] == '(')
            {
                openBracketsIds.Add(i);
            }
            else
            {
                closeBracketsIds.Add(i);
            }
        }

        if (openBracketsIds.Count != closeBracketsIds.Count)
            return false;

        for (var i = 0; i < openBracketsIds.Count; i++)
        {
            if (openBracketsIds[i] > closeBracketsIds[i])
                return false;
        }

        return true;
    }

    // Time complexity: O(n), n є 2Z
    // Space complexity:  2 <= O(n) <= 1000, n є 2Z
    public static bool Stack(string str)
    {
        if (string.IsNullOrWhiteSpace(str) || str.Length % 2 != 0)
            return false;

        var openBracketsStack = new Stack<int>();

        foreach (var @char in str)
        {
            if (@char == '(')
            {
                openBracketsStack.Push(@char);
            }
            else
            {
                if (openBracketsStack.Count == 0)
                    return false;

                openBracketsStack.Pop();
            }
        }

        return openBracketsStack.Count == 0;
    }

    // Time complexity: O(n), n є 2Z
    // Space complexity: O(1)
    public static bool Counter(string str)
    {
        if (string.IsNullOrWhiteSpace(str) || str.Length % 2 != 0)
            return false;

        var openBracketsCounter = 0;

        foreach (var @char in str)
        {
            if (@char == '(')
            {
                openBracketsCounter++;
            }
            else
            {
                if (openBracketsCounter == 0)
                    return false;

                openBracketsCounter--;
            }
        }

        return openBracketsCounter == 0;
    }
}
