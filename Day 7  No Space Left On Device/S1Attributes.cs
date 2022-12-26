namespace Day_7__No_Space_Left_On_Device;

public class S1Attributes
{
   public int SentenceIndex;
   public int SumOfAllDirWithAtMost100M = 0;
   public readonly Dictionary<string, Directory> Directories = new Dictionary<string, Directory>();
   public readonly List<string> Path = new List<string>();
}
