using Foothold.Geometry;

namespace Foothold.Game;

public interface IField
{
    IFoothold? FindClosest(Point2D point);
    IFoothold? FindBelow(Point2D point);
    IFoothold? FindUnderneath(Point2D point);
}