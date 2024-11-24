namespace Algo.Tests;

using Floors = string[];

partial class FallingRocksTests
{
    public static IEnumerable<TestCaseData> All =>
            NoRocksFell_SingleFloor
                .Concat(RocksFell_SingleColumn)
                .Concat(RocksFell_TwoColumns)
                .Concat(GenericTests);

    public static IEnumerable<TestCaseData> NoRocksFell_SingleFloor
    {
        get
        {
            var tcdThunk = MakeTCDThunk("{m} Single floor no falls: {a}");

            yield return tcdThunk([""], [""]);
            yield return tcdThunk(["#"], ["#"]);
            yield return tcdThunk(["##"], ["##"]);
            yield return tcdThunk(["###"], ["###"]);
            yield return tcdThunk(["####"], ["####"]);
            yield return tcdThunk(["#####"], ["#####"]);
            yield return tcdThunk(["# #"], ["# #"]);
            yield return tcdThunk(["# # #"], ["# # #"]);
            yield return tcdThunk(["## ##"], ["## ##"]);
            yield return tcdThunk(["#### #"], ["#### #"]);
        }
    }

    public static IEnumerable<TestCaseData> RocksFell_SingleColumn
    {
        get
        {
            var tcdThunk = MakeTCDThunk("{m} Single column simple falls: {a}");

            yield return tcdThunk([
                "#",
                " "
            ], [
                " ",
                "#"
            ]);

            yield return tcdThunk([
                "#",
                "#",
                " "
            ], [
                " ",
                "#",
                "#"
            ]);

            yield return tcdThunk([
                "#",
                " ",
                "#"
            ], [
                " ",
                "#",
                "#"
            ]);
        }
    }

    public static IEnumerable<TestCaseData> RocksFell_TwoColumns
    {
        get
        {
            var tcdThunk = MakeTCDThunk("{m} Two columns simple falls: {a}");

            yield return tcdThunk([
                "# ",
                " #"
            ], [
                "  ",
                "##"
            ]);

            yield return tcdThunk([
                "# ",
                "##",
                " #"
            ], [
                "  ",
                "##",
                "##"
            ]);

            yield return tcdThunk([
                "# ",
                "  ",
                "# "
            ], [
                "  ",
                "# ",
                "# "
            ]);
        }
    }

    public static IEnumerable<TestCaseData> GenericTests
    {
        get
        {
            var tcdThunk = MakeTCDThunk("{m} Generic test: {a}");

            yield return tcdThunk([
                "##########",
                "          ",
                "          ",
                "          ",
                "          "
            ], [
                "          ",
                "          ",
                "          ",
                "          ",
                "##########"
            ]);

            yield return tcdThunk([
                "# # # # # # # # # ",
                " # # # # # # # # #",
                "# # # # # # # # # ",
                " # # # # # # # # #",
                "# # # # # # # # # ",
                " # # # # # # # # #",
            ], [
                "                  ",
                "                  ",
                "                  ",
                "##################",
                "##################",
                "##################"
            ]);

            yield return tcdThunk([
                "#         ",
                " #        ",
                "  #       ",
                "   #      ",
                "    #     ",
                "     #    ",
                "      #   ",
                "       #  ",
                "        # ",
                "         #",
            ], [
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "##########"
            ]);

            yield return tcdThunk([
                "         #",
                "        # ",
                "       #  ",
                "      #   ",
                "     #    ",
                "    #     ",
                "   #      ",
                "  #       ",
                " #        ",
                "#         ",
            ], [
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "##########"
            ]);

            yield return tcdThunk([
                "##########",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "##########",
            ], [
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "##########",
                "##########",
            ]);

            yield return tcdThunk([
                "#        #",
                " #      # ",
                "  #    #  ",
                "   #  #   ",
                "    ##    ",
                "   #  #   ",
                "  #    #  ",
                " #      # ",
                "#        #",
            ], [
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "####  ####",
                "##########",
            ]);

            var fullHalf = Enumerable.Repeat(new string('#', 64), 32);
            var emptyHalf = Enumerable.Repeat(new string(' ', 64), 32);

            var fullHalfEmptyHalf = fullHalf.Concat(emptyHalf).ToArray();
            var emptyHalfFullHalf = emptyHalf.Concat(fullHalf).ToArray();

            yield return tcdThunk(fullHalfEmptyHalf, emptyHalfFullHalf);
        }
    }

    static Func<Floors, Floors, TestCaseData> MakeTCDThunk(string name) =>
        (Floors @in, Floors @out) => CreateCase(@in, @out).SetName(name);

    static TestCaseData CreateCase(Floors @in, Floors @out) =>
        new(FloorsToString(@in), FloorsToString(@out));

    static string FloorsToString(string[] floors) =>
        string.Join(Environment.NewLine, floors);
}
