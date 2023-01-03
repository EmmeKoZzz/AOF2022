namespace Day_9_Rope_Bridge;

public class Tail
{
   // Attributes
   private readonly Knot[] _tail;
   private Knot _head;

   // Constructor
   public Tail(Knot head, int tailSize)
   {
      _tail = new Knot[tailSize];
      _head = head;
   }

   //Actions
   public Knot this[int x] => _tail[x];

   public Knot Last => _tail.Last();

   private Knot GetHead(int tailIndex)
   {
      if (tailIndex == 0) return _head;
      return _tail[tailIndex - 1];
   }

   public void Move(Knot newHead)
   {
      Knot prevHead = _head;
      _head = newHead;

      for (int i = 0; i < _tail.Length; i++)
      {
         if (!_tail[i].IsClose(GetHead(i)))
            (_tail[i], prevHead) = (prevHead, _tail[i]); // llegar a esta mierda me llevo tiempo xD jajajaaj
         else break;
      }
   }
}
