using Foothold.Geometry;

namespace Foothold.Game;

public class Foothold : IFoothold
{
    public int ID { get; init; }
    public Segment2D Segment { get; init; }

    public Foothold(int id, Segment2D segment)
    {
        ID = id;
        Segment = segment;
    }
}