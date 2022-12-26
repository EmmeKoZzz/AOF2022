namespace Day_3_Rucksack_Reorganization;

public class Solution1
{
   public static int SumPriorities(string input)
   {
      StreamReader reader = new StreamReader(input);
      int sum = 0;

      for (string? ruckStack = reader.ReadLine(); ruckStack != null; ruckStack = reader.ReadLine())
         sum += GetFailPriority(ruckStack);

      return sum;
   }

   static int GetFailPriority(string ruckStack)
   {
      int compartimentLength = ruckStack.Length / 2;
      List<int> firstCompartiment = new List<int>();

      for (int i = 0; i < compartimentLength * 2; i++)
         if (i < compartimentLength)
            firstCompartiment.Add(ruckStack[i]);
         else if (firstCompartiment.Contains(ruckStack[i]))
            return Program.GetPriority(ruckStack[i]);

      return 0;
   }
}
