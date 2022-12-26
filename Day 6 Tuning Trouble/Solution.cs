namespace Day_6_Tuning_Trouble;

static class Solution
{
   public static int GetCharCountBeforeMarket(string input, int markerLenght)
   {
      char[] marker = new char[markerLenght];

      for (int i = 0, j = 0; i < input.Length; i++)
      {
         marker[j] = input[i];

         int moveCursor = CompareToOther(marker, input[i], j);

         if (moveCursor > 0)
         {
            for (int k = 0; k + moveCursor < marker.Length; k++)
               marker[k] = marker[k + moveCursor];

            j -= moveCursor-1;
         }
         else j++;

         if (j >= marker.Length) return i + 1;
      }

      throw new Exception("no marker found");
   }

   // devuelve true si no encuentra valores iguales en el array, falso si lo hace
   static int CompareToOther<T>(T[] compareTo, T value, int fromIndex)
   {
      if (value == null || fromIndex < 0 || fromIndex >= compareTo.Length)
         throw new Exception("invalid Data to Compare");

      for (int i = fromIndex-1; i >= 0; i--)
         if (compareTo[i]!.Equals(value))
            return i+1;

      return 0;
   }
}
