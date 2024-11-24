using System.Text;

namespace Algo.Solvers;

// Failing rocks
//Example(in the examples, spaces are replaced by the '-' character for readability) :

//“-#--#”

//“--##-”

//“----#”

//“#--#-”

//The result(in the examples, spaces are replaced by the '-' character for readability):

//“-----”

//“-----”

//“---##”

//“#####”

//Explanation:

//In the first column, no changes occur, because the stone has no place to fall - it already occupies the lowest available position
//In the second and third columns, there is one “hanging” stone each - they fall to the very bottom
//In the fourth column, the upper stone falls on the lower one, leaving two empty spaces above it
//In the fifth column, each of the stones falls to the lowest available space, forming the same column as the fourth

public static class FallingRocksSolver
{
    private const char EmptySymbol = ' ';
    private const char RockSymbol = '#';
    private static readonly string Separator = "\r\n";

    // Time complexity: O(2L + M * N * N) = 2 * 4222 + 64^3 = 270_588, where N is rows, M is columns, L - length of string
    // Space complexity: O(3L) = 3 * 4222 = 12_666, where L is length of input string
    public static string Matrix(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        if (input.Length > 4222)
            throw new ArgumentException("Bro, you promised me that length of input string would be in [0; 4222]");

        var (matrix, rows, cols) = GetMatrix(input);

        if (rows > 64 || rows == 0 || cols > 64 || cols == 0)
            throw new ArgumentException("Bro, you promised me that 0 < N <= 64, 0 < M <= 64");

        for (var j = 0; j < cols; j++)
        {
            for (var i = rows - 1; i >= 0; i--)
            {
                if (matrix[i, j] == EmptySymbol)
                    continue;

                int lowestRowId = i;
                for (var k = i + 1; k < rows; k++)
                {
                    if (matrix[k, j] == EmptySymbol)
                        lowestRowId = k;
                }

                if (lowestRowId != i)
                {
                    matrix[lowestRowId, j] = RockSymbol;
                    matrix[i, j] = EmptySymbol;
                }
            }
        }

        var result = MatrixToString(matrix, rows, cols);
        return result;

        static (char[,], int, int) GetMatrix(string input)
        {
            var countOfSeparators = 0;
            var isColsCountFound = false;
            var cols = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == Separator[0])
                {
                    countOfSeparators++;
                    i++;

                    isColsCountFound = true;
                }

                if (!isColsCountFound)
                    cols++;
            }

            var rows = countOfSeparators > 0 ? countOfSeparators + 1 : 1;

            char[,] matrix = new char[rows, cols];

            var currentRow = 0;
            var currentCol = 0;

            input = input.Replace(Separator, "");
            foreach (var @char in input)
            {
                matrix[currentRow, currentCol] = @char;

                if (currentCol == cols - 1)
                {
                    currentRow++;
                    currentCol = 0;
                }
                else
                    currentCol++;
            }

            return (matrix, rows, cols);
        }

        static string MatrixToString(char[,] matrix, int rows, int cols)
        {
            StringBuilder result = new();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    result.Append(matrix[i, j]);

                if (i != rows - 1)
                    result.Append("\r\n");
            }

            return result.ToString();
        }
    }

    // Time complexity: O(M + L * L / M) = 64 + 4222 * 4222 / 64 = 278_584, where M is columns, L - length of string
    // Space complexity: O(L) = 4222, where L is length of input string
    public static string ColumnsCountStepSb(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        if (input.Length > 4222)
            throw new ArgumentException("Bro, you promised me that length of input string would be in [0; 4222]");

        var columnsCount = 0;
        for (var i = 0; i < input.Length; i++)
        {
            if (input[i] == Separator[0])
                break;

            columnsCount++;
        }

        columnsCount += Separator.Length;

        var sb = new StringBuilder(input);
        for (var i = 0; i < sb.Length; i++)
        {
            if (sb[i] == EmptySymbol)
                continue;

            var lowestPositionToSwap = i;

            for (var j = i + columnsCount; j < sb.Length; j += columnsCount)
            {
                if (sb[j] == EmptySymbol)
                    lowestPositionToSwap = j;
            }

            if (lowestPositionToSwap != i)
            {
                sb[i] = EmptySymbol;
                sb[lowestPositionToSwap] = RockSymbol;
            }
        }

        return sb.ToString();
    }

    // Time complexity: O(M + L * L / M) = 64 + 4222 * 4222 / 64 = 278_584, where M is columns, L - length of string
    // Space complexity: O(L) = 4222, where L is length of input string
    public static string ColumnsCountStepCharArr(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        if (input.Length > 4222)
            throw new ArgumentException("Bro, you promised me that length of input string would be in [0; 4222]");

        var columnsCount = 0;
        for (var i = 0; i < input.Length; i++)
        {
            if (input[i] == Separator[0])
                break;

            columnsCount++;
        }

        columnsCount += Separator.Length;

        var inputArray = input.ToCharArray();
        for (var i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] == EmptySymbol)
                continue;

            var lowestPositionToSwap = i;

            for (var j = i + columnsCount; j < inputArray.Length; j += columnsCount)
            {
                if (inputArray[j] == EmptySymbol)
                    lowestPositionToSwap = j;
            }

            if (lowestPositionToSwap != i)
            {
                inputArray[i] = EmptySymbol;
                inputArray[lowestPositionToSwap] = RockSymbol;
            }
        }

        return new string(inputArray);
    }
}
