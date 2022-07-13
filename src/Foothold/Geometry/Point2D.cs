namespace Foothold.Geometry;

public struct Point2D
{
    public int X { get; }
    public int Y { get; }

    public Point2D(int x, int y) { X = x; Y = y; }

    public double Distance(Point2D point)
        => Math.Sqrt(Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2));

    public bool IsAbove(Segment2D segment)
        => segment.IsBelow(this);

    public bool IsBelow(Segment2D segment)
        => segment.IsAbove(this);

    public bool Intersects(Segment2D segment)
        => segment.Intersects(this);

    public bool Intersects(Rectangle2D rectangle)
        => rectangle.Intersects(this);

    public override string ToString()
        => $"({X}, {Y})";
}