namespace Algo.Solvers;

// Task: Check if long number is palindrome

public static class LongPalindromeSolver
{
    // Time complexity: O(n), where n is digit numbers
    // Space complexity: O(1)
    public static bool Division(ulong number)
    {
        if (number < 0)
            return false;

        if (number < 10)
            return true;

        var digits = CountDigits(number);

        var firstNumberDivider = CalculateInitialFirstNumberDivider(digits);
        while (number >= 10)
        {
            var firstNumber = number / firstNumberDivider;
            var lastNumber = number % 10;

            if (firstNumber != lastNumber)
                return false;

            number = number % firstNumberDivider / 10;
            firstNumberDivider /= 100;
        }

        return true;

        static int CountDigits(ulong num)
        {
            if (num == 0)
            {
                return 1;
            }

            int digits = 0;
            while (num != 0)
            {
                num /= 10;
                digits++;
            }

            return digits;
        }

        static ulong CalculateInitialFirstNumberDivider(int digits)
        {
            ulong divider = 1;
            for (int i = 0; i < digits - 1; i++)
            {
                divider *= 10;
            }
            return divider;
        }
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public static bool DivideStrings(ulong number)
    {
        if (number < 0)
            return false;

        if (number < 10)
            return true;

        var numberStr = number.ToString();

        var halfOfLength = numberStr.Length / 2;
        var halfShift = (CountDigits(number) % 2 == 1) ? 1 : 0;

        var firstHalf = numberStr[..halfOfLength];
        var secondHalf = new string(numberStr[(halfOfLength + halfShift)..].Reverse().ToArray());

        return firstHalf == secondHalf;

        static int CountDigits(ulong num)
        {
            if (num == 0)
            {
                return 1;
            }

            int digits = 0;
            while (num != 0)
            {
                num /= 10;
                digits++;
            }

            return digits;
        }
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public static bool ReverseNumber(ulong number)
    {
        if (number < 0)
            return false;

        if (number < 10)
            return true;

        var inputNumber = number;

        var reversedNumber = 0UL;
        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + number % 10;
            number /= 10;
        }

        return inputNumber == reversedNumber;
    }
}
