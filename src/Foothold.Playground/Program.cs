using Duey;
using Foothold.Game;
using Foothold.Geometry;

var file = new NXFile("../../data/Map.nx");
var loader = new FieldDataLoader(file);
var data = await loader.Load(310000000);

Console.WriteLine(data);

var line = new Segment2D(new(0, 1), new(2, 3));

Console.WriteLine(line.Middle);