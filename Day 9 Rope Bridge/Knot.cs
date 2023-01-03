namespace Day_9_Rope_Bridge;

public struct Knot
{
    // Attributes
    public int X { get; private set; }
    public int Y { get; private set; }

    // Constructor
    public Knot(int x, int y)
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

    public bool StepTo(Knot head)
    {
        if (IsClose(head)) return false;
        int x = X - head.X;
        int y = Y - head.Y;
        x /= Math.Abs(x);
        y /= Math.Abs(y);
        Step(x,y);
        return true;
    }
    


    public bool IsClose(Knot p)
    {
        if (Equals(p)) return true;
        // N,S,E,W,NE,NW,SE,SW
        int[] x = { 0, 0, 1, -1, 1, -1, 1, -1 };
        int[] y = { 1, -1, 0, 0, 1, 1, -1, -1 };

        for (int i = 0; i < 8; i++)
        {
            Knot pTemp = p;
            pTemp.Step(x[i], y[i]);

            if (this.Equals(pTemp))
                return true;
        }

        return false;
    }

    // Equality Propeties
    public static bool operator ==(Knot p1, Knot p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }

    public static bool operator !=(Knot p1, Knot p2)
    {
        return !(p1.X == p2.X && p1.Y == p2.Y);
    }

    private bool Equals(Knot other)
    {
        return X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj)
    {
        return obj is Knot other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}