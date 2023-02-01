using System;
using System.Collections.Generic;
using Geo.Models;
using Microsoft.EntityFrameworkCore;

namespace Geo.Context;

internal partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PointXYZ> Points { get; set; }

    public virtual DbSet<Country> Poland { get; set; }

    public virtual DbSet<Voivodeship> Voivodeships { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder
            .UseNpgsql("Host=localhost;Username=postgres;Password=postgres;Database=zadanie", x => x.UseNetTopologySuite())
            .UseSnakeCaseNamingConvention();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("postgis");

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("polska_pkey");

            entity.ToTable("polska");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,2180)")
                .HasColumnName("geom");
            entity.Property(e => e.GmlId)
                .HasMaxLength(254)
                .HasColumnName("gml_id");
            entity.Property(e => e.IdBufor1)
                .HasMaxLength(254)
                .HasColumnName("id_bufor_1");
            entity.Property(e => e.IdBufora)
                .HasMaxLength(254)
                .HasColumnName("id_bufora_");
            entity.Property(e => e.IdBufora1)
                .HasMaxLength(254)
                .HasColumnName("id_bufora1");
            entity.Property(e => e.IdTechnic)
                .HasMaxLength(254)
                .HasColumnName("id_technic");
            entity.Property(e => e.IipIdenty)
                .HasMaxLength(254)
                .HasColumnName("iip_identy");
            entity.Property(e => e.IipPrzest)
                .HasMaxLength(254)
                .HasColumnName("iip_przest");
            entity.Property(e => e.IipWersja)
                .HasMaxLength(254)
                .HasColumnName("iip_wersja");
            entity.Property(e => e.JptGeom1)
                .HasMaxLength(254)
                .HasColumnName("jpt_geom_1");
            entity.Property(e => e.JptGeomet)
                .HasMaxLength(254)
                .HasColumnName("jpt_geomet");
            entity.Property(e => e.JptId)
                .HasMaxLength(254)
                .HasColumnName("jpt_id");
            entity.Property(e => e.JptJorId)
                .HasMaxLength(254)
                .HasColumnName("jpt_jor_id");
            entity.Property(e => e.JptKjI1)
                .HasMaxLength(254)
                .HasColumnName("jpt_kj_i_1");
            entity.Property(e => e.JptKjI2)
                .HasMaxLength(254)
                .HasColumnName("jpt_kj_i_2");
            entity.Property(e => e.JptKjI3)
                .HasMaxLength(254)
                .HasColumnName("jpt_kj_i_3");
            entity.Property(e => e.JptKjIip)
                .HasMaxLength(254)
                .HasColumnName("jpt_kj_iip");
            entity.Property(e => e.JptKod1)
                .HasMaxLength(254)
                .HasColumnName("jpt_kod__1");
            entity.Property(e => e.JptKodJe)
                .HasMaxLength(254)
                .HasColumnName("jpt_kod_je");
            entity.Property(e => e.JptNazwa)
                .HasMaxLength(254)
                .HasColumnName("jpt_nazwa_");
            entity.Property(e => e.JptNazwa1)
                .HasMaxLength(254)
                .HasColumnName("jpt_nazwa1");
            entity.Property(e => e.JptOpis)
                .HasMaxLength(254)
                .HasColumnName("jpt_opis");
            entity.Property(e => e.JptOrgan)
                .HasMaxLength(254)
                .HasColumnName("jpt_organ_");
            entity.Property(e => e.JptOrgan1)
                .HasMaxLength(254)
                .HasColumnName("jpt_organ1");
            entity.Property(e => e.JptPowi1)
                .HasMaxLength(254)
                .HasColumnName("jpt_powi_1");
            entity.Property(e => e.JptPowier)
                .HasMaxLength(254)
                .HasColumnName("jpt_powier");
            entity.Property(e => e.JptSjrKo)
                .HasMaxLength(254)
                .HasColumnName("jpt_sjr_ko");
            entity.Property(e => e.JptSpsKo)
                .HasMaxLength(254)
                .HasColumnName("jpt_sps_ko");
            entity.Property(e => e.JptWazna)
                .HasMaxLength(254)
                .HasColumnName("jpt_wazna_");
            entity.Property(e => e.Rodzaj)
                .HasMaxLength(254)
                .HasColumnName("rodzaj");
            entity.Property(e => e.ShapeArea)
                .HasMaxLength(254)
                .HasColumnName("shape_area");
            entity.Property(e => e.ShapeLeng)
                .HasMaxLength(254)
                .HasColumnName("shape_leng");
            entity.Property(e => e.WaznyDo)
                .HasMaxLength(254)
                .HasColumnName("wazny_do");
            entity.Property(e => e.WaznyOd)
                .HasMaxLength(254)
                .HasColumnName("wazny_od");
            entity.Property(e => e.WersjaDo)
                .HasMaxLength(254)
                .HasColumnName("wersja_do");
            entity.Property(e => e.WersjaOd)
                .HasMaxLength(254)
                .HasColumnName("wersja_od");
        });

        modelBuilder.Entity<Voivodeship>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wojewodztwa_pkey");

            entity.ToTable("wojewodztwa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,2180)")
                .HasColumnName("geom");
            entity.Property(e => e.GmlId)
                .HasMaxLength(254)
                .HasColumnName("gml_id");
            entity.Property(e => e.IdBufor1)
                .HasMaxLength(254)
                .HasColumnName("id_bufor_1");
            entity.Property(e => e.IdBufora)
                .HasMaxLength(254)
                .HasColumnName("id_bufora_");
            entity.Property(e => e.IdBufora1)
                .HasMaxLength(254)
                .HasColumnName("id_bufora1");
            entity.Property(e => e.IdTechnic)
                .HasMaxLength(254)
                .HasColumnName("id_technic");
            entity.Property(e => e.IipIdenty)
                .HasMaxLength(254)
                .HasColumnName("iip_identy");
            entity.Property(e => e.IipPrzest)
                .HasMaxLength(254)
                .HasColumnName("iip_przest");
            entity.Property(e => e.IipWersja)
                .HasMaxLength(254)
                .HasColumnName("iip_wersja");
            entity.Property(e => e.JptGeom1)
                .HasMaxLength(254)
                .HasColumnName("jpt_geom_1");
            entity.Property(e => e.JptGeomet)
                .HasMaxLength(254)
                .HasColumnName("jpt_geomet");
            entity.Property(e => e.JptId)
                .HasMaxLength(254)
                .HasColumnName("jpt_id");
            entity.Property(e => e.JptJorId)
                .HasMaxLength(254)
                .HasColumnName("jpt_jor_id");
            entity.Property(e => e.JptKjI1)
                .HasMaxLength(254)
                .HasColumnName("jpt_kj_i_1");
            entity.Property(e => e.JptKjI2)
                .HasMaxLength(254)
                .HasColumnName("jpt_kj_i_2");
            entity.Property(e => e.JptKjI3)
                .HasMaxLength(254)
                .HasColumnName("jpt_kj_i_3");
            entity.Property(e => e.JptKjIip)
                .HasMaxLength(254)
                .HasColumnName("jpt_kj_iip");
            entity.Property(e => e.JptKod1)
                .HasMaxLength(254)
                .HasColumnName("jpt_kod__1");
            entity.Property(e => e.JptKodJe)
                .HasMaxLength(254)
                .HasColumnName("jpt_kod_je");
            entity.Property(e => e.JptNazwa)
                .HasMaxLength(254)
                .HasColumnName("jpt_nazwa_");
            entity.Property(e => e.JptNazwa1)
                .HasMaxLength(254)
                .HasColumnName("jpt_nazwa1");
            entity.Property(e => e.JptOpis)
                .HasMaxLength(254)
                .HasColumnName("jpt_opis");
            entity.Property(e => e.JptOrgan)
                .HasMaxLength(254)
                .HasColumnName("jpt_organ_");
            entity.Property(e => e.JptOrgan1)
                .HasMaxLength(254)
                .HasColumnName("jpt_organ1");
            entity.Property(e => e.JptPowi1)
                .HasMaxLength(254)
                .HasColumnName("jpt_powi_1");
            entity.Property(e => e.JptPowier)
                .HasMaxLength(254)
                .HasColumnName("jpt_powier");
            entity.Property(e => e.JptSjrKo)
                .HasMaxLength(254)
                .HasColumnName("jpt_sjr_ko");
            entity.Property(e => e.JptSpsKo)
                .HasMaxLength(254)
                .HasColumnName("jpt_sps_ko");
            entity.Property(e => e.JptWazna)
                .HasMaxLength(254)
                .HasColumnName("jpt_wazna_");
            entity.Property(e => e.Regon)
                .HasMaxLength(254)
                .HasColumnName("regon");
            entity.Property(e => e.Rodzaj)
                .HasMaxLength(254)
                .HasColumnName("rodzaj");
            entity.Property(e => e.ShapeArea)
                .HasMaxLength(254)
                .HasColumnName("shape_area");
            entity.Property(e => e.ShapeLeng)
                .HasMaxLength(254)
                .HasColumnName("shape_leng");
            entity.Property(e => e.WaznyDo)
                .HasMaxLength(254)
                .HasColumnName("wazny_do");
            entity.Property(e => e.WaznyOd)
                .HasMaxLength(254)
                .HasColumnName("wazny_od");
            entity.Property(e => e.WersjaDo)
                .HasMaxLength(254)
                .HasColumnName("wersja_do");
            entity.Property(e => e.WersjaOd)
                .HasMaxLength(254)
                .HasColumnName("wersja_od");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
