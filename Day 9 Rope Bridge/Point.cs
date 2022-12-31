namespace Day_9_Rope_Bridge;

public struct Point
{
   // Attributes
   public int X { get; private set; }
   public int Y { get; private set; }

   // Constructor
   public Point(int x, int y)
   {
      X = x;
      Y = y;
   }

   // Actions
   public void Step(int xStep, int yStep)
   {
      X += xStep;
      Y += yStep;
   }

   public bool IsClose(Point p)
   {
      if (this.Equals(p)) return true;
      // N,S,E,W,NE,NW,SE,SW
      int[] x = { 0, 0, 1, -1, 1, -1, 1, -1 };
      int[] y = { 1, -1, 0, 0, 1, 1, -1, -1 };

      for (int i = 0; i < 8; i++)
      {
         Point pTemp = p;
         pTemp.Step(x[i], y[i]);

         if (this.Equals(pTemp))
            return true;
      }

      return false;
   }

   // Equality Propeties
   public static bool operator ==(Point p1, Point p2)
   {
      return p1.X == p2.X && p1.Y == p2.Y;
   }

   public static bool operator !=(Point p1, Point p2)
   {
      return !(p1.X == p2.X && p1.Y == p2.Y);
   }

   private bool Equals(Point other)
   {
      return X == other.X && Y == other.Y;
   }

   public override bool Equals(object? obj)
   {
      return obj is Point other && Equals(other);
   }

   public override int GetHashCode()
   {
      return HashCode.Combine(X, Y);
   }
}
