using Day_4_Camp_Cleanup;

namespace Day_4_Camp_Cleanup;

class App
{
   public static void Main()
   {
      string input = "../../../input.txt";
      int solution1 = Solution1.GetCompletyOverlapPairCount(input);
      Console.WriteLine(solution1);
      int solution2 = Solution2.GetOverlapPairCount(input);
      Console.WriteLine(solution2);
   }

   public static int[][] GetPairs(string line)
   {
      string[] pairs = line.Trim().Split(",");
      string[] pair1Str = pairs[0].Split("-");
      string[] pair2Str = pairs[1].Split("-");

      int[] pair1 = { int.Parse(pair1Str[0]), int.Parse(pair1Str[1]) };
      int[] pair2 = { int.Parse(pair2Str[0]), int.Parse(pair2Str[1]) };

      return new[] { pair1, pair2 };
   }
}
