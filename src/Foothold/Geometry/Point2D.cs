namespace Foothold.Geometry;

public struct Point2D
{
    public float X { get; }
    public float Y { get; }

    public Point2D(int x, int y) { X = x; Y = y; }
    public Point2D(float x, float y) { X = x; Y = y; }

    public override string ToString()
        => $"({X}, {Y})";
}