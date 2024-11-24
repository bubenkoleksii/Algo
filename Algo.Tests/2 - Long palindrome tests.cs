namespace Algo.Tests;

[TestFixture]
public class LongPalindromeTests
{
    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { 0UL, true },
            new object[] { 121UL, true },
            new object[] { 100001UL, true },
            new object[] { 12345_6_54321UL, true },
            new object[] { 184467440_66_044764481UL, true },
            new object[] { 100010UL, false },
            new object[] { 18446744_0_66_1_44764481UL, false },
            new object[] { (ulong)1e19, false },
            new object[] { ulong.MaxValue, false }
        };

    [TestCaseSource(nameof(TestData))]
    public void Division_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSolver.Division(number);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [TestCaseSource(nameof(TestData))]
    public void DivideString_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSolver.DivideStrings(number);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [TestCaseSource(nameof(TestData))]
    public void ReverseNumber_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSolver.ReverseNumber(number);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
