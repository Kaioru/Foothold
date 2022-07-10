namespace Foothold.Geometry;

public struct Segment2D
{
    public Point2D P1 { get; }
    public Point2D P2 { get; }

    public Segment2D(Point2D p1, Point2D p2) { P1 = p1; P2 = p2; }
}