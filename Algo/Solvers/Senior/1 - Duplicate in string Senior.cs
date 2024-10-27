using System.Collections.Specialized;

namespace Algo.Solvers;

public static class StringDuplicateSeniorSolver
{
    // Takes Nth char (N>=1) and checks if [..N] substring contains it.
    public static char Contains(string Input)
    {
        for (var i = 1; i < Input.Length; i++)
            if (Input![..i].Contains(Input![i]))
                return Input[i];

        throw new Exception("Brother you promised repeated chars.");
    }

    // Adds seen chars to List<char>.
    public static char List(string Input)
    {
        var seen = new List<char>();
        foreach (var @char in Input)
        {
            if (seen.Contains(@char))
                return @char;

            seen.Add(@char);
        }

        throw new Exception("Brother you promised repeated chars.");
    }

    // Adds seen chars to HashSet<char>.
    public static char HashSet(string Input)
    {
        HashSet<char> result = [];

        foreach (var c in Input)
        {
            if (!result.Add(c))
                return c;
        }

        throw new Exception("Brother you promised repeated chars.");
    }

    // Uses Int32 as bitmask.
    public static char BitMask(string Input)
    {
        var bitmask = 0;

        foreach (var i in Input)
        {
            var shift = i - 'a';

            if ((bitmask & (1 << shift)) != 0)
                return i;

            bitmask |= (1 << shift);
        }

        throw new Exception("Brother you promised repeated chars.");
    }

    // Uses 26 bool array allocated on stack.
    public static char Stackalloc(string Input)
    {
        Span<bool> buffer = stackalloc bool[26];

        foreach (var @char in Input)
        {
            if (buffer[@char - 'a']) // (byte)'z' - (byte)'a' = 25;
                return @char;
            buffer[@char - 'a'] = true;
        }

        throw new Exception("Brother you promised repeated chars.");
    }

    // Uses System.Collections.Specialized.BitVector32
    public static char BitVector32(string Input)
    {
        var vector = new BitVector32();

        foreach (var i in Input)
        {
            var bit = (1 << (i - 'a'));

            if (vector[bit])
                return i;

            vector[bit] = true;
        }

        throw new Exception("Brother you promised repeated chars.");
    }

    // Uses custom bit vector wrapper.
    public static char CustomBitVector(string Input)
    {
        var vector = new CustomBitVector32();

        foreach (var @char in Input)
        {
            var bit = @char - 'a';
            if (vector.Has(bit))
                return @char;

            vector.Set(bit);
        }

        throw new Exception("Brother you promised repeated chars.");
    }
}

record struct CustomBitVector32
{
    int Bitmask;

    public void Set(int n) =>
        Bitmask |= (1 << n);

    public readonly bool Has(int n) =>
        (Bitmask & (1 << n)) != 0;
}