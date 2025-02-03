namespace Algo.Tests;

[TestFixture]
public class KeyboardRowTests
{
    public static IEnumerable<TestCaseData> Data
    {
        get
        {
            yield return new TestCaseData("ALASKA", true);
            yield return new TestCaseData("poWer", true);
            yield return new TestCaseData("tweRp", true);
            yield return new TestCaseData("qEri", true);
            yield return new TestCaseData("mnc", true);

            yield return new TestCaseData("q", true);
            yield return new TestCaseData("a", true);
            yield return new TestCaseData("z", true);

            yield return new TestCaseData(new string('x', (int)1e3), true);
            yield return new TestCaseData(new string('x', 999) + 'a', false);

            yield return new TestCaseData("jazz", false);
            yield return new TestCaseData("palm", false);
            yield return new TestCaseData("test", false);
        }
    }

    [TestCaseSource(nameof(Data))]
    public void RowIdLoop_Tests(string str, bool expectedResult)
    {
        var result = KeyboardRowSolver.RowIdLoop(str);

        Assert.That(expectedResult, Is.EqualTo(result));
    }

    [TestCaseSource(nameof(Data))]
    public void RowIdLoopDistinct_Tests(string str, bool expectedResult)
    {
        var result = KeyboardRowSolver.RowIdLoopDistinct(str);

        Assert.That(expectedResult, Is.EqualTo(result));
    }

    [TestCaseSource(nameof(Data))]
    public void RowIdLoopHashSet_Tests(string str, bool expectedResult)
    {
        var result = KeyboardRowSolver.RowIdLoopHashSet(str);

        Assert.That(expectedResult, Is.EqualTo(result));
    }

    [TestCaseSource(nameof(Data))]
    public void RowIdLoopFrozenSet_Tests(string str, bool expectedResult)
    {
        var result = KeyboardRowSolver.RowIdLoopFrozenSet(str);

        Assert.That(expectedResult, Is.EqualTo(result));
    }

    [TestCaseSource(nameof(Data))]
    public void Regex_Tests(string str, bool expectedResult)
    {
        var result = KeyboardRowSolver.Regex(str);

        Assert.That(expectedResult, Is.EqualTo(result));
    }
}
