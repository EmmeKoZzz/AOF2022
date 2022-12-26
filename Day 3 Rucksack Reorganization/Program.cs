namespace Day_3_Rucksack_Reorganization;

class Program
{
   public static void Main()
   {
      string input = "../../../input.txt";
      int solution1 = Solution1.SumPriorities(input);
      int solution2 = Solution2.SumBadgePriorities(input);
      Console.WriteLine(solution1);
      Console.WriteLine(solution2);
   }

   public static int GetPriority(char type)
   {
      if (type <= 90 && type >= 65)
         return type - 64+26; // MAYUSCULAS   xD no queria calcular la suma jajajajajja
      if (type <= 122 && type >= 97)
         return type - 96; // minusculas
      throw new Exception("invalid item");
   }
}
