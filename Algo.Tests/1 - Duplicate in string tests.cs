namespace Algo.Tests;

[TestFixture]
public class DuplicateInStringTests
{
    [TestCase("aqrmmtak", 'm')]
    [TestCase("abcdefgabc", 'a')]
    [TestCase("zxyzzxyz", 'z')]
    [TestCase("hellohe", 'l')]
    [TestCase("character", 'a')]
    [TestCase("randomletters", 't')]
    public void GetFirstDuplicateLetter_SimpleLoops_Tests(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSolver.GetFirstDuplicateLetter_SimpleLoops(inputStr);
        Assert.That(letter, Is.EqualTo(expectedLetter));
    }

    [TestCase("aqrmmtak", 'm')]
    [TestCase("abcdefgabc", 'a')]
    [TestCase("zxyzzxyz", 'z')]
    [TestCase("hellohe", 'l')]
    [TestCase("character", 'a')]
    [TestCase("randomletters", 't')]
    public void GetFirstDuplicateLetter_ArrayWithCounts_Tests(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSolver.GetFirstDuplicateLetter_ArrayWithCounts(inputStr);
        Assert.That(letter, Is.EqualTo(expectedLetter));
    }

    [TestCase("aqrmmtak", 'm')]
    [TestCase("abcdefgabc", 'a')]
    [TestCase("zxyzzxyz", 'z')]
    [TestCase("hellohe", 'l')]
    [TestCase("character", 'a')]
    [TestCase("randomletters", 't')]
    public void GetFirstDuplicateLetter_HashSets(string inputStr, char expectedLetter)
    {
        var letter = StringDuplicateSolver.GetFirstDuplicateLetter_HashSets(inputStr);
        Assert.That(letter, Is.EqualTo(expectedLetter));
    }
}
