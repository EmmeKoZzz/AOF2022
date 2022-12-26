namespace Day_5_Supply_Stacks;

public class Stacks
{
   public int Count { get; }
   public List<char>[] Stack { get; }

   public Stacks(string stacks)
   {
      Count = GetStacksCount(stacks);
      Stack = GetStacks(stacks);
   }

   static int GetStacksCount(string stacks)
   {
      StreamReader reader = new StreamReader(stacks);
      return int.Parse(reader.ReadToEnd().Replace(" ", "").ReplaceLineEndings("").Last() + "");
   }

   List<char>[] GetStacks(string stacks)
   {
      StreamReader reader = new StreamReader(stacks);
      List<char>[] stack = new List<char>[Count];

      for (int i = 0; i < Count; i++)
         stack[i] = new List<char>();

      for (string? line = reader.ReadLine(); line != null; line = reader.ReadLine())
      for (int t = 0; t < line.Length; t++)
         if (line[t] >= 65 && line[t] <= 90)
            stack[t / 4].Add(line[t]);

      reader.Close();
      return stack;
   }
}
