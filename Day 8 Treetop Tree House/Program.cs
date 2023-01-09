using System.Diagnostics;

namespace Day_8_Treetop_Tree_House;

static class App
{
    public static void Main()
    {
        string inputfile = "/home/mkz/Coding../AOF2022/Day 8 Treetop Tree House/input.txt";
        StreamReader reader = new StreamReader(inputfile);
        string[] input = reader.ReadToEnd().Split("\n", StringSplitOptions.RemoveEmptyEntries);
        reader.Close();

        Stopwatch time = new();
        time.Start();
        Solution solution = new Solution(input);
        time.Stop();

        Console.WriteLine(time.Elapsed.TotalSeconds);
        Console.WriteLine();

        Console.WriteLine(solution.VisibleTrees);
        Console.WriteLine(solution.HighestTreeScore);
    }
}