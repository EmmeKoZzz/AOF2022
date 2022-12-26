namespace Day_7__No_Space_Left_On_Device;

public class Command
{
   // Attributes
   public string Com { get; private set; }
   public string? Arg { get; private set; }

   // Constructor
   public Command(string command)
   {
      string[] commandsParts = command.Split(" ");
      Com = (commandsParts[1]);
      Arg = Com == "cd" ? commandsParts[2] : null;
   }

   // Actions ( Commands )
   public static void List(string[] sentences, S1Attributes props)
   {
      do
      {
         props.SentenceIndex++;
         string sentence = sentences[props.SentenceIndex];
         string[] sentenceParts = sentence.Split(" ");

         if (Sentence.IsFile(sentence))
            foreach (string directory in props.Path)
            {
               int fileSize = int.Parse(sentenceParts[0]);
               props.Directories[directory].Size += fileSize;

               if (props.Directories[directory].Check)
               {
                  int dirSize = props.Directories[directory].Size;
                  if (dirSize <= 100000)
                     props.SumOfAllDirWithAtMost100M += fileSize;
                  else
                  {
                     props.Directories[directory].Check = false;
                     props.SumOfAllDirWithAtMost100M -= dirSize - fileSize;
                  }
               }
            }
         else
         {
            string dirChild = Solution.GetDirectory(sentenceParts[1], props.Path.Last());
            if (props.Directories.ContainsKey(dirChild))
               props.Directories[props.Path.Last()].Size += props.Directories[dirChild].Size;
            else
               props.Directories.Add(dirChild, new Directory());
         }

         if (props.SentenceIndex >= sentences.Length - 1) break;
      } while (!Sentence.IsCommmand(sentences[props.SentenceIndex + 1]));
   }

   public static void ChangeDir(string? arg, S1Attributes props)
   {
      if (arg == null) throw new Exception("Invalid directory");

      switch (arg)
      {
         case "/":
            props.Path.RemoveRange(0, props.Path.Count);
            props.Path.Add("/");
            if (!props.Directories.ContainsKey("/"))
               props.Directories.Add("/", new Directory());
            break;
         case "..":
            props.Path.RemoveAt(props.Path.Count - 1);
            break;
         default:
            props.Path.Add(Solution.GetDirectory(arg, props.Path.Last()));
            break;
      }
   }
}
