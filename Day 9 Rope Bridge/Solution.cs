using System.Diagnostics;

namespace Day_9_Rope_Bridge;

public class Solution
{
   public List<Point> TailSteps;

   public Solution(string[] input)
   {
      Point head = new Point(0, 0);
      Point tail = new Point(0, 0);
      TailSteps = new List<Point>() { new Point(0, 0) };

      foreach (string inputSentence in input)
      {
         string[] sentence = inputSentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
         char direction = sentence[0][0];
         int stepsCount = int.Parse(sentence[1]);

         for (int i = 0; i < stepsCount; i++)
         {
            Point beforeHead = head;
            switch (direction)
            {
               case 'U':
                  head.Step(0, 1);
                  break;
               case 'D':
                  head.Step(0, -1);
                  break;
               case 'L':
                  head.Step(-1, 0);
                  break;
               case 'R':
                  head.Step(1, 0);
                  break;
               default:
                  throw new Exception("invalid direction: " + direction);
            }

            if (!tail.IsClose(head))
            {
               tail = beforeHead;
               if (!TailSteps.Contains(tail))
                  TailSteps.Add(tail);
            }
         }
      }
   }
}
