namespace Day_3_Rucksack_Reorganization;

public class Solution2
{
   public static int SumBadgePriorities(string input)
   {
      StreamReader reader = new StreamReader(input);

      int sum = 0, i = 0;
      char[][] elfGroup = new char[3][];

      for (string? ruckStack = reader.ReadLine(); ruckStack != null; ruckStack = reader.ReadLine())
      {
         char[] ruckStackToChar = ruckStack.ToCharArray();
         Array.Sort(ruckStackToChar);
         elfGroup[i] = ruckStackToChar;
         i++;

         if (i == 3)
         {
            i = 0;
            sum += GetBadge(elfGroup);
         }
      }

      return sum;
   }

   static int GetBadge(char[][] elfGroup)
   {
      int lenght = elfGroup[0].Length;
      for (int i = 0; i < lenght - 1; i++)
      {
         var (cursor, nextItem) = (elfGroup[0][i], elfGroup[0][i + 1]);
         if (cursor != nextItem)
         {
            int seach = Seach(elfGroup, cursor);
            if (seach > 0) return seach;
         }
      }
      return Seach(elfGroup, elfGroup[0].Last());
   }

   static int Seach(char[][] elfGroup, char cursor)
   {
      if (Array.BinarySearch(elfGroup[1], cursor) >= 0)
         if (Array.BinarySearch(elfGroup[2], cursor) >= 0)
            return Program.GetPriority(cursor);
      return 0;
   }
}
