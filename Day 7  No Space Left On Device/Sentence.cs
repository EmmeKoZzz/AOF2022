namespace Day_7__No_Space_Left_On_Device;

public class Sentence
{
   // Actions
   public static bool IsFile(string sentence)
   {
      try
      {
         return int.Parse(sentence.Split(" ")[0]) >= 0;
      }
      catch
      {
         return false;
      }
   }

   public static bool IsCommmand(string sentence)
   {
      return sentence.Trim()[0] == '$';
   }

   public static bool IsDir(string sentence)
   {
      return sentence.Split(" ")[0] == "dir";
   }
}
