using Foothold.Geometry;

namespace Foothold.Game;

public interface IField
{
    Segment2D? FindClosest(Point2D point);
    Segment2D? FindUnderneath(Point2D point);
    Segment2D? FindBelow(Point2D point);
}