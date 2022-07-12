using Duey;
using Foothold.Game;

var file = new NXFile("../../data/Map.nx");
var loader = new FieldDataLoader(file);
var data = await loader.Load(310000000);

Console.WriteLine(data);