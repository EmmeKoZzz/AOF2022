namespace Day_9_Rope_Bridge;

public class Solution
{
   public readonly List<Knot> TailSteps;

   public Solution(string[] input, int tailSize)
   {
      Knot head = new Knot(0, 0);
      Tail tail = new Tail(head, tailSize);

      TailSteps = new List<Knot> { new(0, 0) };

      foreach (string inputSentence in input)
      {
         string[] sentence = inputSentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
         char direction = sentence[0][0];
         int stepsCount = int.Parse(sentence[1]);

         for (int i = 0; i < stepsCount; i++)
         {
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

            tail.Move(head);
            if (!TailSteps.Contains(tail.Last))
               TailSteps.Add(tail.Last);
         }
      }
   }
}
