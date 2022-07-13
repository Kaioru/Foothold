using System.Reflection.Metadata;
using Duey;
using Foothold.Algo.RBush;
using Foothold.Game;
using Foothold.Geometry;

var line = new Segment2D(new(0, 0), new(10, 0));
var point1 = new Point2D(0, -1);
var point2 = new Point2D(-1, -1);

Console.WriteLine(point1.IsBelow(line));
Console.WriteLine(point2.IsBelow(line));

var loader = new FieldDataLoader(new NXFile("../../data/Map.nx"));
var data = loader.Load(310000000);
var bush = new RBushField(data);

Console.WriteLine(data.Bounds);
Console.WriteLine(data.Bounds.P1);
Console.WriteLine(data.Bounds.P2);
Console.WriteLine(data.Bounds.Bottom);
Console.WriteLine(bush.FindFootholdClosest(new(0, 0))?.Segment);
Console.WriteLine(bush.FindFootholdBelow(new(-50, -15))?.Segment);