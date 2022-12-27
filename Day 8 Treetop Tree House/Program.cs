namespace Day_8_Treetop_Tree_House;

static class App
{
   public static void Main()
   {
      string inputfile = "../../../input.txt";
      StreamReader reader = new StreamReader(inputfile);
      string[] input = reader.ReadToEnd().Split("\n",StringSplitOptions.RemoveEmptyEntries);
      reader.Close();

      Solution solution = new Solution(input);
      Console.WriteLine(solution.VisibleTrees);
      Console.WriteLine(solution.HighestTreeScore);
   }
}
