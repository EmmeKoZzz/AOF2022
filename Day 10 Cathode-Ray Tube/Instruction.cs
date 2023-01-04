namespace Day_10_Cathode_Ray_Tube;

public struct Instruction
{
    public int Value = 0;
    public int Cycles;
    public Instruction(string line)
    {
        string[] lineParts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        switch (lineParts[0])
        {
            case "noop":
                Cycles = 1;
                break;
            case "addx":
                Value = int.Parse(lineParts[1]);
                Cycles = 2;
                break;
            default: throw new Exception("Invalid instruction line");
        }
    }
}