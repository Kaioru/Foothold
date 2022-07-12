using Foothold.Game;
using RBush;

namespace Foothold.Algo.RBush;

public class RBushData : ISpatialData
{
    private readonly Envelope _envelope;
    public ref readonly Envelope Envelope => ref _envelope;

    public IFoothold Foothold { get; }

    public RBushData(IFoothold foothold)
    {
        _envelope = new Envelope(
            MinX: Math.Min(foothold.Segment.P1.X, foothold.Segment.P2.X),
            MinY: Math.Min(foothold.Segment.P1.Y, foothold.Segment.P2.Y),
            MaxX: Math.Max(foothold.Segment.P1.X, foothold.Segment.P2.X),
            MaxY: Math.Max(foothold.Segment.P1.Y, foothold.Segment.P2.Y)
        );
        Foothold = foothold;
    }
}