using Foothold.Geometry;

namespace Foothold.Game;

public interface IFoothold
{
    int ID { get; }
    Segment2D Segment { get; }
}