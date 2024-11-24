using Algo.Solvers;

namespace Algo;

internal class Program
{
    static void Main()
    {
        var result = FallingRocksSolver.ColumnsCountStepCharArr("·#··#\r\n··##·\r\n····#\r\n#··#·".Replace('·', ' '));
        Console.WriteLine(result.Replace(' ', '·'));
        Console.ReadKey();
    }
}
