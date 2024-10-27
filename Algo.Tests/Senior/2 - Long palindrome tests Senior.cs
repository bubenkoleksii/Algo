namespace Algo.Tests.Senior;

public class LongPalindromeSeniorTests
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
    public void TwoStringUnoptimized_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSeniorSolver.TwoStringUnoptimized(number);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void TwoString_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSeniorSolver.TwoString(number);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void SingleString_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSeniorSolver.SingleString(number);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void SingleStringAsSpan_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSeniorSolver.SingleStringSpan(number);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void SequenceEquals_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSeniorSolver.SequenceEquals(number);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void ReverseNumber_Tests(ulong number, bool expectedResult)
    {
        var result = LongPalindromeSeniorSolver.ReverseNumber(number);
        Assert.Equal(expectedResult, result);
    }
}
