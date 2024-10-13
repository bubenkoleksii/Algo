using Algo.Solvers;

namespace Algo.Tests;

public class DuplicateInStringTests
{
    [Theory]
    [InlineData("aqrmmtak", 'm')]
    [InlineData("abcdefgabc", 'a')]
    [InlineData("zxyzzxyz", 'z')]
    [InlineData("hellohe", 'l')]
    [InlineData("character", 'a')]
    [InlineData("randomletters", 't')]
    public void GetFirstDuplicateLetter_SimpleLoops_Tests(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSolver.GetFirstDuplicateLetter_SimpleLoops(inputStr);
        Assert.Equal(expectedLetter, letter);
    }

    [Theory]
    [InlineData("aqrmmtak", 'm')]
    [InlineData("abcdefgabc", 'a')]
    [InlineData("zxyzzxyz", 'z')]
    [InlineData("hellohe", 'l')]
    [InlineData("character", 'a')]
    [InlineData("randomletters", 't')]
    public void GetFirstDuplicateLetter_ArrayWithCounts_Tests(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSolver.GetFirstDuplicateLetter_ArrayWithCounts(inputStr);
        Assert.Equal(expectedLetter, letter);
    }

    [Theory]
    [InlineData("aqrmmtak", 'm')]
    [InlineData("abcdefgabc", 'a')]
    [InlineData("zxyzzxyz", 'z')]
    [InlineData("hellohe", 'l')]
    [InlineData("character", 'a')]
    [InlineData("randomletters", 't')]
    public void GetFirstDuplicateLetter_HashSets(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSolver.GetFirstDuplicateLetter_HashSets(inputStr);
        Assert.Equal(expectedLetter, letter);
    }
}