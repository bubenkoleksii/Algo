namespace Algo.Tests;

[TestFixture]
public class RepeatedCharactersTests
{
    public static IEnumerable<object[]> RepeatedCharacterCases
    {
        get
        {
            yield return new object[] { "", new List<(char, int)>() };
            yield return new object[] { "a", new List<(char, int)> { ('a', 1) } };
            yield return new object[] { "abc", new List<(char, int)> { ('a', 1), ('b', 1), ('c', 1) } };
            yield return new object[] { "aaaa", new List<(char, int)> { ('a', 4) } };
            yield return new object[] { "aabbaa", new List<(char, int)> { ('a', 2), ('b', 2), ('a', 2) } };
            yield return new object[] { "abababab", new List<(char, int)> { ('a', 1), ('b', 1), ('a', 1), ('b', 1), ('a', 1), ('b', 1), ('a', 1), ('b', 1) } };
            yield return new object[] { "aaabbbcccaaa", new List<(char, int)> { ('a', 3), ('b', 3), ('c', 3), ('a', 3) } };
            yield return new object[] { "aAaaA", new List<(char, int)> { ('a', 1), ('A', 1), ('a', 2), ('A', 1) } };
            yield return new object[] { "aa11##bb", new List<(char, int)> { ('a', 2), ('1', 2), ('#', 2), ('b', 2) } };
            yield return new object[] { "aa  bb", new List<(char, int)> { ('a', 2), (' ', 2), ('b', 2) } };
            yield return new object[] { "aaçççaaa", new List<(char, int)> { ('a', 2), ('ç', 3), ('a', 3) } };
        }
    }

    [TestCaseSource(nameof(RepeatedCharacterCases))]
    public void Counter_Tests(string input, List<(char, int)> expected)
    {
        var result = RepeatedCharactersSolver.Counter(input);

        Assert.That(result.Count, Is.EqualTo(expected.Count));
        for (int i = 0; i < expected.Count; i++)
            Assert.That(result[i], Is.EqualTo(expected[i]));
    }

    [TestCaseSource(nameof(RepeatedCharacterCases))]
    public void Regex_Tests(string input, List<(char, int)> expected)
    {
        var result = RepeatedCharactersSolver.Regex(input);

        Assert.That(result.Count, Is.EqualTo(expected.Count));
        for (int i = 0; i < expected.Count; i++)
            Assert.That(result[i], Is.EqualTo(expected[i]));
    }
}
