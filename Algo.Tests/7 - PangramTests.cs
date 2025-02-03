namespace Algo.Tests;

[TestFixture]
public class PangramTests
{
    [Test, TestCaseSource(nameof(Data))]
    public void OneLiner(string input, bool expected) => Assert.That(PangramSolver.OneLiner(input), Is.EqualTo(expected));

    [Test, TestCaseSource(nameof(Data))]
    public void Counters(string input, bool expected) => Assert.That(PangramSolver.Counters(input), Is.EqualTo(expected));

    [Test, TestCaseSource(nameof(Data))]
    public void Mask(string input, bool expected) => Assert.That(PangramSolver.Mask(input), Is.EqualTo(expected));

    [Test, TestCaseSource(nameof(Data))]
    public void Regex(string input, bool expected) => Assert.That(PangramSolver.Regex(input), Is.EqualTo(expected));

    public static IEnumerable<TestCaseData> Data
    {
        get
        {
            yield return new("abcdefghijklmnopqrstuvwxyz", true);
            yield return new("thequickbrownfoxjumpsoverthelazydog", true);
            yield return new("packmyboxwithfivedozenliquorjugs", true);
            yield return new("waltznymphforquickjigsvexbud", true);
            yield return new("glibjocksquiznymphtovexdwarf", true);
            yield return new("sphinxofblackquartzjudgemyvow", true);
            yield return new("jackdawslovemybigsphinxofquartz", true);
            yield return new("howvexinglyquickdaftzebrasjump", true);

            yield return new("hellotherehowareyoutoday", false);
            yield return new("simplewordswithoutallletters", false);
            yield return new("thissentenceismissingajqxz", false);
            yield return new("codingisfunwhenitsimple", false);
            yield return new("tryingtomakeastringwithoutz", false);
            yield return new("functionscancurrybutnotpangram", false);
            yield return new("writingnonsenseisquiteodd", false);
            yield return new("somelongwordslackvitalletters", false);
            yield return new("heresanexamplewithoutjandz", false);
            yield return new("letscheckifthismissessomething", false);

            yield return new("abcdefghijklnnopqrstuvwxyz", false);
        }
    }
}

