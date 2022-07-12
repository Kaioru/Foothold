using Duey;
using Foothold.Data;

namespace Foothold.Game;

public class FieldDataLoader : IDataLoader<FieldData>
{
    private readonly NXFile _file;

    public FieldDataLoader(NXFile file)
        => _file = file;

    public async Task<FieldData> Load(int id)
    {
        Console.WriteLine($"Map/Map{Math.Floor(id / 100000000d)}/{id.ToString().PadLeft(9, '0')}.img");
        //var node = _file.ResolvePath($"Map/Map{Math.Floor(id / 100000000d)}/{id.ToString().PadLeft(9, '0')}.img");

        return new FieldData
        {
            ID = id
        };
    }
}