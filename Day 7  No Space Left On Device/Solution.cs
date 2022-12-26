namespace Day_7__No_Space_Left_On_Device;

public class Solution
{
   // Attributes
   public int SumOfAllDirWithAtMost100M { get; }
   public int SizeOfSmallestButEnoughtDir { get; }
   private readonly S1Attributes _props = new S1Attributes();

   // Constructor
   public Solution(string[] input)
   {
      for (_props.SentenceIndex = 0; _props.SentenceIndex < input.Length; _props.SentenceIndex++)
      {
         string sentence = input[_props.SentenceIndex];
         if (Sentence.IsCommmand(sentence))
         {
            Command command = new Command(sentence);
            RunCommand(command, input);
         }
         else
            throw new Exception("Invalid Input");
      }
      this.SumOfAllDirWithAtMost100M = _props.SumOfAllDirWithAtMost100M;
      this.SizeOfSmallestButEnoughtDir = Solution2.GetSmallestButEnoughDir(_props.Directories);
   }

   private void RunCommand(Command command, string[] sentences)
   {
      switch (command.Com)
      {
         case "cd":
            Command.ChangeDir(command.Arg, _props);
            break;

         case "ls":
            Command.List(sentences, _props);
            break;

         default:
            throw new Exception("Invalid Command");
      }
   }

   public static string GetDirectory(string current, string prev = "")
   {
      return prev == "" ? "/" : prev + current + "/";
   }
}
