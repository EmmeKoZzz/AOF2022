namespace Day_9_Rope_Bridge;

class App
{
   public static void Main()
   {
      StreamReader reader = new StreamReader("../../../input.txt");
      string[] input = reader.ReadToEnd().Split("\n", StringSplitOptions.RemoveEmptyEntries);

      Solution solution = new Solution(input);
      Console.WriteLine(solution.TailSteps.Count);
   }
}
