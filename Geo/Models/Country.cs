using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Geo.Models;

internal partial class Country
{
    public int Id { get; set; }

    public MultiPolygon? Geom { get; set; }

    public string? GmlId { get; set; }

    public string? JptSjrKo { get; set; }

    public string? JptPowier { get; set; }

    public string? JptKodJe { get; set; }

    public string? JptNazwa { get; set; }

    public string? JptOrgan { get; set; }

    public string? JptJorId { get; set; }

    public string? WersjaOd { get; set; }

    public string? WersjaDo { get; set; }

    public string? WaznyOd { get; set; }

    public string? WaznyDo { get; set; }

    public string? JptKod1 { get; set; }

    public string? JptNazwa1 { get; set; }

    public string? JptOrgan1 { get; set; }

    public string? JptWazna { get; set; }

    public string? IdBufora { get; set; }

    public string? IdBufora1 { get; set; }

    public string? IdTechnic { get; set; }

    public string? IipPrzest { get; set; }

    public string? IipIdenty { get; set; }

    public string? IipWersja { get; set; }

    public string? JptKjIip { get; set; }

    public string? JptKjI1 { get; set; }

    public string? JptKjI2 { get; set; }

    public string? JptOpis { get; set; }

    public string? JptSpsKo { get; set; }

    public string? IdBufor1 { get; set; }

    public string? JptId { get; set; }

    public string? JptPowi1 { get; set; }

    public string? JptKjI3 { get; set; }

    public string? JptGeomet { get; set; }

    public string? JptGeom1 { get; set; }

    public string? ShapeLeng { get; set; }

    public string? ShapeArea { get; set; }

    public string? Rodzaj { get; set; }
}
