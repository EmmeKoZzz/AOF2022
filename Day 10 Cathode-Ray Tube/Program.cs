namespace Day_10_Cathode_Ray_Tube;

internal static class App
{
    private static void Main()
    {
        var instructions = 
            new StreamReader("/home/mkz/Coding../AOF2022/Day 10 Cathode-Ray Tube/input.txt").ReadToEnd().Split('\n');

        var cpu = new CpuProgram();

        cpu.SetInstructions(instructions);
    }
}