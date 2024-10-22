namespace Algo.Tests;

public class LongPalindromeTests
{
    public static IEnumerable<object[]> TestData =>
    [
        [0UL, true],

        [121UL, true],
        [100001UL, true],
        [12345_6_54321UL, true],
        [184467440_66_044764481UL, true],

        [100010UL, false],
        [18446744_0_66_1_44764481UL, false],
        [(ulong)1e19,false],
        [ulong.MaxValue, false],
    ];

    [Theory]
    [MemberData(nameof(TestData))]
    public void Division_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSolver.Division(number);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void DivideString_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSolver.DivideStrings(number);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void ReverseNumber_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSolver.ReverseNumber(number);
        Assert.Equal(expectedResult, result);
    }
}
