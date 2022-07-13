namespace Foothold.Geometry;

public struct Segment2D
{
    public Point2D P1 { get; }
    public Point2D P2 { get; }

    public Segment2D(Point2D p1, Point2D p2) { P1 = p1; P2 = p2; }

    public Point2D Middle => new((P1.X + P2.X) / 2, (P1.Y + P2.Y) / 2);

    public double Length => P1.Distance(P2);
    public double Slope => IsVertical ? 0 : (P2.Y - P1.Y) / (P2.X - P1.X);
    public bool IsVertical => P1.X == P2.X;
    public bool IsHorizontal => P1.Y == P2.Y;

    public bool IsAbove(Point2D point)
        => Cross(point) > 0;

    public bool IsBelow(Point2D point)
        => Cross(point) < 0;

    public bool Intersects(Point2D point)
        => point.Distance(P1) + point.Distance(P2) == P1.Distance(P2);

    public int Cross(Point2D point)
        => (point.X - P1.X) * (P2.Y - P1.Y) - (point.Y - P1.Y) * (P2.X - P1.X);

    public override string ToString()
        => $"Segment {P1} -> {P2}";
}