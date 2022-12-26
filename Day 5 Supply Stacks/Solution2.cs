namespace Day_5_Supply_Stacks;

static class Solution2
{
   public static void UseInstruction(Stacks stacks, Inst instruction)
   {
      List<char> crane = new List<char>();

      for (int i = 0; i < instruction.Move; i++)
      {
         if (stacks.Stack[instruction.From].Count == 0) break;
         char crate = stacks.Stack[instruction.From][0];
         crane.Add(crate);
         stacks.Stack[instruction.From].RemoveAt(0);
      }
      stacks.Stack[instruction.To].InsertRange(0,crane);
   }
}
