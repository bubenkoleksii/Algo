namespace Algo.Tests;

public class LongPalindromeTests
{
    public static IEnumerable<object[]> TestData =>
    [
        [5L, true],
        [1221L, true],
        [694202496L, true],
        [123454322L, false],
        [0L, true],
        [1001L, true],
        [12321L, true],
        [45654L, true],
        [123456L, false],
        [-121L, false],
        [9876789L, true],
        [1000000001L, true],
        [123456789L, false],
        [808L, true],
        [123454321L, true],
        [111111L, true],
        [2002L, true],
        [12345654321L, true],
        [111L, true],
        [99999L, true],
        [12345678987654321L, true],
        [1234567890987654321L, true],
        [456789L, false],
        [12L, false],
        [999999L, true],
        [12344321L, true],
        [54321L, false],
        [1000001L, true],
        [9090909L, true],
    ];

    [Theory]
    [MemberData(nameof(TestData))]
    public void Division_Tests(long number, bool expectedResult)
    {
        var result = LongPalindromeSolver.Division(number);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void DivideString_Tests(long number, bool expectedResult)
    {
        var result = LongPalindromeSolver.DivideStrings(number);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void ReverseNumber_Tests(long number, bool expectedResult)
    {
        var result = LongPalindromeSolver.ReverseNumber(number);
        Assert.Equal(expectedResult, result);
    }
}
