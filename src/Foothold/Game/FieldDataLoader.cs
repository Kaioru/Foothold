using Duey;
using Foothold.Data;

namespace Foothold.Game;

public class FieldDataLoader : IDataLoader<FieldData>
{
    private readonly NXFile _file;

    public FieldDataLoader(NXFile file)
        => _file = file;

    public FieldData Load(int id)
    {
        var node = _file.ResolvePath($"Map/Map{Math.Floor(id / 100000000d)}/{id.ToString().PadLeft(9, '0')}.img");
        var nodeInfo = node.ResolvePath("info").ResolveAll();
        var nodeFh = node.ResolvePath("foothold").ResolveAll();

        var footholds = nodeFh
            .SelectMany(f => f.Children)
            .SelectMany(f => f.Children)
            .ToDictionary(
                p => Convert.ToInt32(p.Name),
                p => (IFoothold)new Foothold(
                    Convert.ToInt32(p.Name),
                    new(
                        new(p.Resolve<int>("x1") ?? 0, p.Resolve<int>("y1") ?? 0),
                        new(p.Resolve<int>("x2") ?? 0, p.Resolve<int>("y2") ?? 0)
                    )
            )
        );

        var vrLeft = nodeInfo.Resolve<int>("VRLeft");
        var vrTop = nodeInfo.Resolve<int>("VRTop");
        var vrRight = nodeInfo.Resolve<int>("VRRight");
        var vrBottom = nodeInfo.Resolve<int>("VRBottom");

        return new FieldData(id, vrLeft, vrTop, vrRight, vrBottom, footholds);
    }
}