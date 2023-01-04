namespace Day_10_Cathode_Ray_Tube;

internal static class App
{
    private static void Main()
    {
        var instructions = 
            new StreamReader("/home/mkz/Coding../AOF2022/Day 10 Cathode-Ray Tube/input.txt").ReadToEnd().Split('\n');

        var cpu = new CpuProgram();

        cpu.SetInstructions(instructions);

        int sumOfSignalStrengths = 0;

        foreach (int eval in new[] { 20, 60, 100, 140, 180, 220 })
            sumOfSignalStrengths += cpu.GetSigntalStrengthAt(eval);

        Console.WriteLine(sumOfSignalStrengths);
    }
}