using BenchmarkDotNet.Attributes;
using Duey;
using Foothold.Algo.Array;
using Foothold.Algo.RBush;
using Foothold.Game;
using Foothold.Geometry;
using MoreLinq;

namespace Foothold.Benchmarks;

public class FindFootholdUnderneathBenchmarks
{
    private FieldData data;
    private ArrayField array;
    private RBushField rbush;

    public IEnumerable<Point2D> Values => new Point2D[] {
        new (0, 0),
        new (429, 298),
        new (9000, 9000),
    };

    [ParamsSource(nameof(Values))]
    public Point2D Point;

    [GlobalSetup]
    public void Setup()
    {
        var loader = new FieldDataLoader(new NXFile("Map.nx"));

        data = loader.Load(310000000);
        array = new ArrayField(data);
        rbush = new RBushField(data);
    }

    [Benchmark]
    public IFoothold? Array() => array.FindFootholdUnderneath(Point);

    [Benchmark]
    public IFoothold? RBush() => rbush.FindFootholdUnderneath(Point);
}