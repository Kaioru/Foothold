using System.Runtime.Serialization.Formatters;
using Foothold.Game;
using Foothold.Geometry;

namespace Foothold.Algo.Array;

public class ArrayField : IField
{
    private readonly FieldData _data;

    public ArrayField(FieldData data)
    {
        _data = data;
    }

    public IFoothold? FindFootholdClosest(Point2D point)
        => _data.Footholds.Values
            .OrderBy(f => f.Segment.Middle.Distance(point))
            .FirstOrDefault();

    public IFoothold? FindFootholdBelow(Point2D point)
        => _data.Footholds.Values
            .Where(f => f.Segment.IsBelow(point))
            .OrderBy(f => f.Segment.Middle.Distance(point))
            .FirstOrDefault();

    public IFoothold? FindFootholdUnderneath(Point2D point)
        => _data.Footholds.Values
            .Where(f => f.Segment.Intersects(point))
            .FirstOrDefault();
}