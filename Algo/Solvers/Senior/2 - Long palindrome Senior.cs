namespace Algo.Solvers;

public static class LongPalindromeSeniorSolver
{
    public static bool TwoStringUnoptimized(ulong N) =>
        N.ToString() == new string(N.ToString().Reverse().ToArray());

    public static bool TwoString(ulong N)
    {
        if (N != 0 && N % 10 == 0) return false;
        if (N < 10) return true;

        var str = N.ToString();
        var arr = str.ToCharArray();

        Array.Reverse(arr);

        return str == new string(arr);
    }

    public static bool SingleString(ulong N)
    {
        if (N != 0 && N % 10 == 0) return false;
        if (N < 10) return true;

        var str = N.ToString();

        var l = 0;
        var r = str.Length - 1;

        while (l < r)
        {
            if (str[l] != str[r])
                return false;
            l++;
            r--;
        }

        return true;
    }

    public static bool SingleStringSpan(ulong N)
    {
        if (N != 0 && N % 10 == 0) return false;
        if (N < 10) return true;

        var str = N.ToString().AsSpan();

        var l = 0;
        var r = str.Length - 1;

        while (l < r)
        {
            if (str[l] != str[r])
                return false;
            l++;
            r--;
        }

        return true;
    }

    public static bool SequenceEquals(ulong N)
    {
        if (N != 0 && N % 10 == 0) return false;
        if (N < 10) return true;

        var str = N.ToString();
        var first = str.ToCharArray();
        var second = (char[])first.Clone();

        Array.Reverse(second);

        return Enumerable.SequenceEqual(first, second);
    }

    public static bool ReverseNumber(ulong N)
    {
        if (N != 0 && N % 10 == 0) return false;
        if (N < 10) return true;

        var reverse = 0UL;
        var copy = N;

        while (copy > 0)
        {
            reverse = reverse * 10 + copy % 10;
            copy /= 10;
        }

        return reverse == N;
    }
}
