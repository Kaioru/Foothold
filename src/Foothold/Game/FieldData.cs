using Foothold.Data;

namespace Foothold.Game;

public record FieldData : IData
{
    public int ID { get; }
    public IDictionary<int, IFoothold> Footholds { get; }

    public FieldData(int id, IDictionary<int, IFoothold> footholds)
    {
        ID = id;
        Footholds = footholds;
    }
}