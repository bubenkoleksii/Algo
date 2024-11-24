namespace Algo.Tests;

[TestFixture]
public class RoundBracketsTests
{
    public static IEnumerable<object[]> AllCases => PositiveCases.Concat(NegativeCases);

    public static IEnumerable<object[]> PositiveCases
    {
        get
        {
            yield return new object[] { "()", true };
            yield return new object[] { "(())", true };
            yield return new object[] { "()()", true };
            yield return new object[] { "(()())", true };
            yield return new object[] { new string('(', 5000) + new string(')', 5000), true };
            yield return new object[] { GeneratePairs(5000), true };
        }
    }

    public static IEnumerable<object[]> NegativeCases
    {
        get
        {
            yield return new object[] { "(", false };
            yield return new object[] { ")", false };
            yield return new object[] { ")(", false };

            var left = new string('(', 5000);
            var right = new string(')', 4999);
            yield return new object[] { left + right, false };

            left = new string('(', 5000);
            right = new string(')', 4999);
            yield return new object[] { left + right + "(", false };

            yield return new object[] { "())" + GeneratePairs(4998), false };
        }
    }

    [TestCaseSource(nameof(AllCases))]
    public void TwoIdArrays_Tests(string input, bool expected)
    {
        Assert.That(RoundBracketsSolver.TwoIdArrays(input), Is.EqualTo(expected));
    }

    [TestCaseSource(nameof(AllCases))]
    public void Stack_Tests(string input, bool expected)
    {
        Assert.That(RoundBracketsSolver.Stack(input), Is.EqualTo(expected));
    }

    [TestCaseSource(nameof(AllCases))]
    public void Counter_Tests(string input, bool expected)
    {
        Assert.That(RoundBracketsSolver.Counter(input), Is.EqualTo(expected));
    }

    private static string GeneratePairs(int n) => string.Join("", Enumerable.Repeat("()", n));
}
