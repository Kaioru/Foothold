using Foothold.Geometry;

namespace Foothold.Game;

public interface IField
{
    IFoothold? FindFootholdClosest(Point2D point);
    IFoothold? FindFootholdBelow(Point2D point);
    IFoothold? FindFootholdUnderneath(Point2D point);
}