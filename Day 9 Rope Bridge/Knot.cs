namespace Day_9_Rope_Bridge;

public struct Knot
{
    // Attributes
    public int X { get; private set; }
    public int Y { get; private set; }

    // Constructor
    public Knot(int x, int y)
    {
        (X, Y) = (x, y);
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
        int x = head.X - X,
            y = head.Y - Y;

        x /= x != 0 ? Math.Abs(x) : 1;
        y /= y != 0 ? Math.Abs(y) : 1;
        Step(x, y);
        return true;
    }

    public bool IsClose(Knot p) => Math.Sqrt(Math.Pow(X-p.X,2)+Math.Pow(Y-p.Y,2)) <= Math.Sqrt(2);

    // Equality Propeties
    public static bool operator ==(Knot p1, Knot p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }

    public static bool operator !=(Knot p1, Knot p2)
    {
        return !(p1.X == p2.X && p1.Y == p2.Y);
    }
    
    public override bool Equals(object? obj)
    {
        return obj is Knot other && this == other;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}