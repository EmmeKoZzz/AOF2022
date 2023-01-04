namespace Day_10_Cathode_Ray_Tube;

public class CpuProgram
{
    // ATTRIBUTES
    private int _value = 1;
    private int _cycle;
    private Dictionary<int, int> _memory = new();

    public void SetInstructions(string[] program)
    {
        foreach (var instructionLine in program)
        {
            var instruction = new Instruction(instructionLine);
            
            for (var i = 0; i < instruction.Cycles; i++)
            {
                _cycle++;
                _memory.Add(_cycle, _value);
            }
            
            _value += instruction.Value;
        }
    }
}