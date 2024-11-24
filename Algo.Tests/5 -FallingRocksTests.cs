namespace Algo.Tests;

[TestFixture]
public partial class FallingRocksTests
{
    [Test]
    [TestCaseSource(nameof(NoRocksFell_SingleFloor))]
    [TestCaseSource(nameof(RocksFell_SingleColumn))]
    [TestCaseSource(nameof(RocksFell_TwoColumns))]
    [TestCaseSource(nameof(GenericTests))]
    public void Matrix(string input, string expectedOutput) =>
        TestImpl(FallingRocksSolver.Matrix, input, expectedOutput);

    [Test]
    [TestCaseSource(nameof(NoRocksFell_SingleFloor))]
    [TestCaseSource(nameof(RocksFell_SingleColumn))]
    [TestCaseSource(nameof(RocksFell_TwoColumns))]
    [TestCaseSource(nameof(GenericTests))]
    public void ColumnsCountStepSb(string input, string expectedOutput) =>
        TestImpl(FallingRocksSolver.Matrix, input, expectedOutput);

    [Test]
    [TestCaseSource(nameof(NoRocksFell_SingleFloor))]
    [TestCaseSource(nameof(RocksFell_SingleColumn))]
    [TestCaseSource(nameof(RocksFell_TwoColumns))]
    [TestCaseSource(nameof(GenericTests))]
    public void ColumnsCountStepCharArr(string input, string expectedOutput) =>
        TestImpl(FallingRocksSolver.Matrix, input, expectedOutput);

    static void TestImpl(Func<string, string> impl, string input, string expected)
    {
        var result = impl(input);

        if (result == expected)
            Assert.Pass(ComposeMessage(input, expected, result));
        else
            Assert.Fail(ComposeMessage(input, expected, result));
    }

    static string ComposeMessage(string input, string expected, string actual)
    {
        var format = "Expected to receive {0}{0}{1}{0}{0}and received{0}{0}{2}{0}{0}Input: {0}{0}{3}";

        return string.Format(format,
            Environment.NewLine,
            ToReadable(expected),
            ToReadable(actual),
            ToReadable(input));
    }

    static string ToReadable(string s) =>
        string.Join(Environment.NewLine,
            s.Split(Environment.NewLine)
            .Select(l => $"'{l}'"));
}
