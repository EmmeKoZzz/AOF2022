using Day_5_Supply_Stacks;

namespace Day_5_Supply_Stacks;

class App
{
   public static void Main()
   {
      string input = "../../../input.txt";
      Stacks stacks = new Stacks("../../../stacks.txt");

      string soltion1 = Solution1.GetCratesString(input, stacks, Solution1.UseInstruction);
      Console.WriteLine(soltion1);

      stacks = new Stacks("../../../stacks.txt"); // xD las clases son por referencia jajajaja

      string solution2 = Solution1.GetCratesString(input, stacks, Solution2.UseInstruction); // XD tayas de la programacion modular
      Console.WriteLine(solution2);
   }
}
