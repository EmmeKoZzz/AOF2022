namespace Day_2_Rock_Paper_Scissors;

class AdventD2
{
   public static void Main()
   {
      string input = "../../../input.txt";
      int solution1 = GetFinalScore(input);
      Console.WriteLine(solution1);

      int solucion2 = GetRealFinalScore(input);
      Console.WriteLine(solucion2);
   }
   private static int GetFinalScore(string input)
   {
      StreamReader reader = new StreamReader(input);
      int maxScore = 0;

      for (string? raund = reader.ReadLine(); raund != null; raund = reader.ReadLine())
      {
         maxScore += GetScore(raund);
      }
      return maxScore;
   }
   private static int GetRealFinalScore(string input)
   {
      StreamReader reader = new StreamReader(input);
      int maxScore = 0;

      for (string? raund = reader.ReadLine(); raund != null; raund = reader.ReadLine())
      {
         maxScore += GetRealScore(raund);
      }
      return maxScore;
   }
   static int GetScore(string raund)
   {
      string[] plays = raund.Split(" ");
      Play myPlay = new Play(plays[1]);

      if (plays[0] == myPlay.WinTo) return 6 + myPlay.Score;
      if(plays[0] == myPlay.LoseTo) return myPlay.Score;
      return 3 + myPlay.Score;
   }
   static int GetRealScore(string raund)
   {
      string[] plays = raund.Split(" ");
      Play yourPlay = new Play(plays[0]);

      switch (plays[1])
      {
         case "X":
            return Play.GetPlayScore(yourPlay.WinTo);
         case "Y":
            return 3 + yourPlay.Score;
         case "Z":
            return 6 + Play.GetPlayScore(yourPlay.LoseTo);
         default: throw new Exception("invalid action");
      }
   }
}
class Play
{
   public Play(string playType)
   {
      switch (playType)
      {
         case "A": case "X":
            WinTo = "C";
            LoseTo = "B";
            Score = 1;
            break;
         case "B": case "Y":
            WinTo = "A";
            LoseTo = "C";
            Score = 2;
            break;
         case "C": case "Z":
            WinTo = "B";
            LoseTo = "A";
            Score = 3;
            break;
         default:
            throw new Exception("invalid play");
      }
   }

   public string WinTo { get; }
   public string LoseTo { get; }
   public int Score { get; }

   public static int GetPlayScore(string play)
   {
      switch (play)
      {
         case "A": return 1;
         case "B": return 2;
         case "C": return 3;
         default: throw new Exception("invalid play");
      }
   }
}
