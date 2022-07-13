namespace Foothold.Geometry;

public struct Rectangle2D
{
    public Point2D P1 { get; }
    public Point2D P2 { get; }

    public Rectangle2D(Point2D leftTop, Point2D bottomRight) { P1 = leftTop; P2 = bottomRight; }

    public int Left => Math.Min(P1.X, P2.X);
    public int Right => Math.Max(P1.X, P2.X);
    public int Top => Math.Min(P1.Y, P2.Y);
    public int Bottom => Math.Max(P1.Y, P2.Y);

    public int Height => Math.Abs(P1.Y - P2.Y);
    public int Width => Math.Abs(P1.X - P2.X);

    public bool Intersects(Point2D point)
        =>
            point.X >= Left &&
            point.X <= Right &&
            point.Y >= Top &&
            point.Y <= Bottom;

    public override string ToString()
        => $"{P1} -> {P2} ({Height}x{Width})";
}