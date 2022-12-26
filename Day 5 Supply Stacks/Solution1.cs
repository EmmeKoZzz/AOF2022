namespace Day_5_Supply_Stacks;

static class Solution1
{
   public static string GetCratesString(string input, Stacks stacks, Action<Stacks,Inst> useInstruction)
   {
      StreamReader reader = new StreamReader(input);

      for (string? line = reader.ReadLine(); line != null; line = reader.ReadLine())
      {
         Inst inst = GetInstruction(line);
         useInstruction(stacks, inst);
      }

      string crateString = "";

      foreach (var stack in stacks.Stack)
         crateString += stack[0];

      return crateString;
   }

   public static Inst GetInstruction(string line)
   {
      Inst instruction = new Inst();

      string[] instructionsParts = line.Split("move");
      instructionsParts = instructionsParts[1].Split("from");
      instruction.Move = int.Parse(instructionsParts[0]);
      instructionsParts = instructionsParts[1].Split("to");
      instruction.From = int.Parse(instructionsParts[0]) - 1;
      instruction.To = int.Parse(instructionsParts[1]) - 1;

      return instruction;
   }

   public static void UseInstruction(Stacks stacks, Inst instruction)
   {
      for (int i = 0; i < instruction.Move; i++)
      {
         if (stacks.Stack[instruction.From].Count == 0) break;
         char crane = stacks.Stack[instruction.From][0];
         stacks.Stack[instruction.To].Insert(0, crane);
         stacks.Stack[instruction.From].RemoveAt(0);
      }
   }

   // Delegado Action (metodo q representa una accion)
   public delegate void Action<in T1, in T2>(T1 x,T2 y);
}
