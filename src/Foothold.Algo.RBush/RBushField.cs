using Foothold.Game;
using Foothold.Geometry;
using RBush;

namespace Foothold.Algo.RBush;

public class RBushField : IField
{
    private readonly FieldData _data;
    private readonly RBush<RBushData> _bush;

    public RBushField(FieldData data)
    {
        _data = data;
        _bush = new();

        _bush.BulkLoad(_data.Footholds.Select(kv => new RBushData(kv.Value)));
    }

    public IFoothold? FindFootholdClosest(Point2D point)
        => _bush.Knn(1, point.X, point.Y)
                .Select(d => d.Foothold)
                .FirstOrDefault();

    public IFoothold? FindFootholdBelow(Point2D point)
        => _bush.Search(new(point.X, point.Y, point.X, _data.Bounds.Bottom))
                .Select(d => d.Foothold)
                .OrderBy(f => f.Segment.Middle.Distance(point))
                .FirstOrDefault();

    public IFoothold? FindFootholdUnderneath(Point2D point)
        => _bush.Search(new(point.X, point.Y, point.X, point.Y))
                .Select(d => d.Foothold)
                .Where(f => point.Intersects(f.Segment))
                .FirstOrDefault();
}