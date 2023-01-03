namespace Day_9_Rope_Bridge;

class App
{
   public static void Main()
   {
      StreamReader reader = new StreamReader("../../../input.txt");
      string[] input = reader.ReadToEnd().Split("\n", StringSplitOptions.RemoveEmptyEntries);

      //Solution solution = new Solution(input,1);
      Solution solution2 = new Solution(input,9);
      //Console.WriteLine(solution.TailSteps.Count);
      Console.WriteLine(solution2.TailSteps.Count);
   }
}
