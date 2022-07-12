using System.Diagnostics;
using Duey;
using Foothold.Algo.RBush;
using Foothold.Game;
using Foothold.Geometry;

var file = new NXFile("../../data/Map.nx");
var loader = new FieldDataLoader(file);
var data = await loader.Load(310000000);
var field = new RBushField(data);

var stopwatch = Stopwatch.StartNew();

Console.WriteLine(data.Footholds.Skip(13).First().Value.ID);
Console.WriteLine(data.Footholds.Skip(13).First().Value.Segment);
Console.WriteLine(data.Footholds.Skip(13).First().Value.Segment.Middle);
Console.WriteLine(field.FindFootholdUnderneath(data.Footholds.Skip(13).First().Value.Segment.Middle)?.ID);

Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");

Console.WriteLine(field.FindFootholdClosest(new(0, 0))?.ID);
