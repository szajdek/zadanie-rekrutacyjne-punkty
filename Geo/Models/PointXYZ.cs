using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo.Models
{
    internal class PointXYZ
    {
        public int Id { get; set; }
        public Point Location { get; set; }
        public int? VoivodeshipId { get; set; }
        public Voivodeship Voivodeship { get; set; }
    }
}
