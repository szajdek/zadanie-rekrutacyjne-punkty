// See https://aka.ms/new-console-template for more information
using Geo;

Console.WriteLine("Hello, World!");

GeoOperation geoOperation = new GeoOperation();
geoOperation.AddRandomPointsInPoland();
bool test = geoOperation.ValidateDistanceBetweenAllPoints();
Console.WriteLine($"\nTest {test}");
geoOperation.WritePointsInVoivodeships();
