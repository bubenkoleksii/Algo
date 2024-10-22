namespace Algo.Tests.Senior;

public class StringDuplicateSeniorSolverTests
{
    [Theory]
    [InlineData("abcdefgabc", 'a')]
    [InlineData("zxyzzxyz", 'z')]
    [InlineData("hellohe", 'l')]
    [InlineData("character", 'a')]
    [InlineData("randomletters", 't')]
    public void Contains_Tests(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSeniorSolver.Contains(inputStr);
        Assert.Equal(expectedLetter, letter);
    }

    [Theory]
    [InlineData("abcdefgabc", 'a')]
    [InlineData("zxyzzxyz", 'z')]
    [InlineData("hellohe", 'l')]
    [InlineData("character", 'a')]
    [InlineData("randomletters", 't')]
    public void List_Tests(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSeniorSolver.List(inputStr);
        Assert.Equal(expectedLetter, letter);
    }

    [Theory]
    [InlineData("abcdefgabc", 'a')]
    [InlineData("zxyzzxyz", 'z')]
    [InlineData("hellohe", 'l')]
    [InlineData("character", 'a')]
    [InlineData("randomletters", 't')]
    public void HashSet_Tests(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSeniorSolver.HashSet(inputStr);
        Assert.Equal(expectedLetter, letter);
    }

    [Theory]
    [InlineData("abcdefgabc", 'a')]
    [InlineData("zxyzzxyz", 'z')]
    [InlineData("hellohe", 'l')]
    [InlineData("character", 'a')]
    [InlineData("randomletters", 't')]
    public void BitMask_Tests(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSeniorSolver.BitMask(inputStr);
        Assert.Equal(expectedLetter, letter);
    }

    [Theory]
    [InlineData("abcdefgabc", 'a')]
    [InlineData("zxyzzxyz", 'z')]
    [InlineData("hellohe", 'l')]
    [InlineData("character", 'a')]
    [InlineData("randomletters", 't')]
    public void Stackalloc_Tests(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSeniorSolver.Stackalloc(inputStr);
        Assert.Equal(expectedLetter, letter);
    }

    [Theory]
    [InlineData("abcdefgabc", 'a')]
    [InlineData("zxyzzxyz", 'z')]
    [InlineData("hellohe", 'l')]
    [InlineData("character", 'a')]
    [InlineData("randomletters", 't')]
    public void BitVector32_Tests(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSeniorSolver.BitVector32(inputStr);
        Assert.Equal(expectedLetter, letter);
    }

    [Theory]
    [InlineData("abcdefgabc", 'a')]
    [InlineData("zxyzzxyz", 'z')]
    [InlineData("hellohe", 'l')]
    [InlineData("character", 'a')]
    [InlineData("randomletters", 't')]
    public void CustomBitVector_Tests(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSeniorSolver.CustomBitVector(inputStr);
        Assert.Equal(expectedLetter, letter);
    }
}