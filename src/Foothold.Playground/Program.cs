using Foothold.Geometry;

var line = new Segment2D(new(0, 0), new(10, 0));
var point1 = new Point2D(0, -1);
var point2 = new Point2D(-1, -1);

Console.WriteLine(point1.IsBelow(line));
Console.WriteLine(point2.IsBelow(line));
