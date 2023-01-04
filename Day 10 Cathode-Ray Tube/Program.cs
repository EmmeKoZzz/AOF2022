namespace Day_10_Cathode_Ray_Tube;

internal static class App
{
    private static void Main()
    {
        var instructions =
            new StreamReader("/home/mkz/Coding../AOF2022/Day 10 Cathode-Ray Tube/input.txt").ReadToEnd().Split('\n');

        CpuProgram cpu = new();

        cpu.SetInstructions(instructions);

        int sumOfSignalStrengths = new[] { 20, 60, 100, 140, 180, 220 }.Sum(eval => cpu.GetSigntalStrengthAt(eval));

        Console.WriteLine(sumOfSignalStrengths);
        Console.WriteLine(cpu.CRT);
    }
}