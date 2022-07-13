using Foothold.Data;
using Foothold.Geometry;

namespace Foothold.Game;

public record FieldData : IData
{
    public int ID { get; }

    public Rectangle2D Bounds { get; }

    public IDictionary<int, IFoothold> Footholds { get; }

    public FieldData(
        int id,
        int? vrLeft, int? vrTop, int? vrRight, int? vrBottom,
        IDictionary<int, IFoothold> footholds
    )
    {
        ID = id;
        Footholds = footholds;

        var leftTop = new Point2D(
               footholds.Values.SelectMany(f => new List<int>() { f.Segment.P1.X, f.Segment.P2.X }).OrderBy(f => f).First(),
               footholds.Values.SelectMany(f => new List<int>() { f.Segment.P1.Y, f.Segment.P2.Y }).OrderBy(f => f).First()
           );
        var rightBottom = new Point2D(
            footholds.Values.SelectMany(f => new List<int>() { f.Segment.P1.X, f.Segment.P2.X }).OrderByDescending(f => f).First(),
            footholds.Values.SelectMany(f => new List<int>() { f.Segment.P1.Y, f.Segment.P2.Y }).OrderByDescending(f => f).First()
        );

        leftTop = new Point2D(
            vrLeft ?? leftTop.X,
            vrTop ?? leftTop.Y
        );
        rightBottom = new Point2D(
            vrRight ?? rightBottom.X,
            vrBottom ?? rightBottom.Y
        );

        Bounds = new Rectangle2D(leftTop, rightBottom);
    }
}