namespace Day_4_Camp_Cleanup;

public class Solution2
{
   public static int GetOverlapPairCount(string input)
   {
      StreamReader reader = new StreamReader(input);

      int count = 0;
      for (string? line = reader.ReadLine(); line != null; line = reader.ReadLine())
      {
         int[][] pairs = App.GetPairs(line);
         if (ItsOverlapPair(pairs[0], pairs[1])) count++;
      }

      return count;
   }

   static bool ItsOverlapPair(int[] pair1, int[] pair2)
   {
      bool condition1 = pair1[0] <= pair2[1] && pair1[1] >= pair2[0];
      bool condition2 = pair2[0] <= pair1[1] && pair2[1] >= pair1[0];

      if (condition1 || condition2)
         return true;
      return false;
   }
}
