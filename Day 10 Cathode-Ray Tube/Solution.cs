namespace Day_10_Cathode_Ray_Tube;

public class CpuProgram
{
    // ATTRIBUTES
    private int _value = 1;
    private int _cycle;
    private readonly Dictionary<int, int> _memory = new();
    public string CRT = "";

    // METHODS
    public void SetInstructions(string[] program)
    {
        foreach (var instructionLine in program)
        {
            var instruction = new Instruction(instructionLine);
            for (var i = 0; i < instruction.Cycles; i++)
            {
                _cycle++;
                
                RenderCRT();
                
                _memory.Add(_cycle, _value);
            }

            _value += instruction.Value;
        }
    }

    public int GetSigntalStrengthAt(int cycle) => _memory[cycle] * cycle;

    private void RenderCRT()
    {
        bool printer = _value == (_cycle + 40) % 40  ||
                       _value + 1 == (_cycle + 40) % 40  ||
                       _value + 2 == (_cycle + 40) % 40 ;

        CRT += printer ? "#" : ".";
        if (_cycle % 40 == 0) CRT += '\n';
    }
}