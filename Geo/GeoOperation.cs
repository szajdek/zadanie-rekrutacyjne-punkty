using Geo.Context;
using Geo.Models;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo
{
    internal class GeoOperation
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public void AddRandomPointsInPoland()
        {
            const double Xmin = 14.11667;
            const double Xmax = 24.15;
            const double Ymin = 49;
            const double Ymax = 54.83333;
            const double Zmin = 0;
            const double Zmax = 300;
            var poland = _context.Poland.FirstOrDefault();
            Random random = new Random();
            var randomPoints = new List<PointXYZ>();
            while (randomPoints.Count < 1000)
            {
                double xRandom = random.NextDouble() * (Xmax - Xmin) + Xmin;
                double yRandom = random.NextDouble() * (Ymax - Ymin) + Ymin;
                double zRandom = random.NextDouble() * (Zmax - Zmin) + Zmin;
                var randomPoint = new PointXYZ { Location = new Point(xRandom, yRandom, zRandom) { SRID = 4326 } };
                if (poland.Geom.Contains(randomPoint.Location.ProjectTo(2180)))
                {
                    randomPoints.Add(randomPoint);
                }
            }
            _context.Points.AddRange(randomPoints);
            _context.SaveChanges();
        }

        public bool ValidateDistanceBetweenAllPoints()
        {
            var points = _context.Points.ToList();
            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    double distance = points[j].Location.ProjectTo(2180).Distance(points[i].Location.ProjectTo(2180));
                    if (distance < 3000)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void WritePointsInVoivodeships()
        {
            var pointsInPoland = _context.Points.ToList();
            var voivodeships = _context.Voivodeships.ToList();
            foreach (var voivodeship in voivodeships)
            {
                var pointsInVoivodeship = pointsInPoland.Where(x => x.Location.ProjectTo(2180).Within(voivodeship.Geom)).ToList();
                Console.WriteLine($"\nWojewództwo {voivodeship.JptNazwa}");
                foreach (var point in pointsInVoivodeship)
                {
                    Console.WriteLine($"\tId {point.Id}\tX {point.Location.X:N5}\tY {point.Location.Y:N5}\tZ {point.Location.Z:N0}");
                }
            }
        }
    }
}
