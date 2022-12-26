namespace Day_7__No_Space_Left_On_Device;

static class Solution2
{
   private static int FileSystemCapacity => 70000000;

   public static int GetSmallestButEnoughDir(Dictionary<string, Directory> directories)
   {
      directories = new Dictionary<string, Directory>(directories.OrderBy(pair => pair.Value.Size));
      int spaceAvailable = FileSystemCapacity - directories["/"].Size;

      foreach (Directory dir in directories.Values)
         if (dir.Size + spaceAvailable >= 30000000)
            return dir.Size;

      throw new Exception("Imposible to get dir");
   }
}
