using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CaracolTanqueos.Models;

public partial class TanqueosContext : DbContext
{
    public TanqueosContext()
    {
    }

    public TanqueosContext(DbContextOptions<TanqueosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<CentrosOrdene> CentrosOrdenes { get; set; }

    public virtual DbSet<Conductore> Conductores { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<RegistroTaqueo> RegistroTaqueos { get; set; }

    public virtual DbSet<Responsable> Responsables { get; set; }

    public virtual DbSet<TiposCombustible> TiposCombustibles { get; set; }

    public virtual DbSet<TiposDocumento> TiposDocumentos { get; set; }

    public virtual DbSet<TiposEquipo> TiposEquipos { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    public virtual DbSet<Vicepresidencia> Vicepresidencias { get; set; }

    public virtual DbSet<VwTotal> VwTotals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Areas__3214EC07DC01DBEB");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Areas)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__Areas__IdEstado__4CA06362");

            entity.HasOne(d => d.IdResponsableNavigation).WithMany(p => p.Areas)
                .HasForeignKey(d => d.IdResponsable)
                .HasConstraintName("FK__Areas__IdRespons__4BAC3F29");

            entity.HasOne(d => d.IdVicepresidenciaNavigation).WithMany(p => p.Areas)
                .HasForeignKey(d => d.IdVicepresidencia)
                .HasConstraintName("FK__Areas__IdVicepre__4AB81AF0");
        });

        modelBuilder.Entity<CentrosOrdene>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CentrosO__3214EC0707416663");

            entity.Property(e => e.CodigoSap)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CodigoSAP");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.CentrosOrdenes)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__CentrosOr__IdEst__47DBAE45");
        });

        modelBuilder.Entity<Conductore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Conducto__3214EC078803EDF1");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroTelefono)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Conductores)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__Conductor__IdEst__5629CD9C");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Conductores)
                .HasForeignKey(d => d.IdTipoDocumento)
                .HasConstraintName("FK__Conductor__IdTip__5535A963");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estados__3214EC0754EF8477");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RegistroTaqueo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Registro__3214EC07CE70823A");

            entity.Property(e => e.FechaActualiza).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaTanqueo).HasColumnType("datetime");
            entity.Property(e => e.FotosSoporte)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GalonesTanqueo).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.KilometrajeHoras).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.UsuarioActualiza)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValorGalon).HasColumnType("money");
            entity.Property(e => e.ValorTanqueo).HasColumnType("money");

            entity.HasOne(d => d.IdCentroOrdenNavigation).WithMany(p => p.RegistroTaqueos)
                .HasForeignKey(d => d.IdCentroOrden)
                .HasConstraintName("FK__RegistroT__IdCen__619B8048");

            entity.HasOne(d => d.IdConductorNavigation).WithMany(p => p.RegistroTaqueos)
                .HasForeignKey(d => d.IdConductor)
                .HasConstraintName("FK__RegistroT__IdCon__60A75C0F");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.RegistroTaqueos)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__RegistroT__IdEst__628FA481");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.RegistroTaqueos)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK__RegistroT__Usuar__5FB337D6");
        });

        modelBuilder.Entity<Responsable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reponsab__3214EC074A970A1C");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Responsables)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__Reponsabl__IdEst__3C69FB99");
        });

        modelBuilder.Entity<TiposCombustible>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TiposCon__3214EC07B3FB7FF5");

            entity.ToTable("TiposCombustible");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.TiposCombustibles)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__TiposConb__IdEst__4222D4EF");
        });

        modelBuilder.Entity<TiposDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TiposDoc__3214EC0779D534D0");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.TiposDocumentos)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__TiposDocu__IdEst__44FF419A");
        });

        modelBuilder.Entity<TiposEquipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tipos__3214EC0702CE66B0");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.TiposEquipos)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__Tipos__IdEstado__3F466844");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vehiculo__3214EC079D28038F");

            entity.ToTable(tb => tb.HasTrigger("VehiculosTipoCombustibleInsert"));

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.Vehiculos)
                .HasForeignKey(d => d.IdArea)
                .HasConstraintName("FK__Vehiculos__IdAre__4F7CD00D");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Vehiculos)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__Vehiculos__IdEst__52593CB8");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.Vehiculos)
                .HasForeignKey(d => d.IdTipo)
                .HasConstraintName("FK__Vehiculos__IdTip__5070F446");

            entity.HasOne(d => d.IdTipoCombustibleNavigation).WithMany(p => p.Vehiculos)
                .HasForeignKey(d => d.IdTipoCombustible)
                .HasConstraintName("FK__Vehiculos__IdTip__5165187F");
        });

        modelBuilder.Entity<Vicepresidencia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vicepres__3214EC07FEC31961");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Vicepresidencia)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__Vicepresi__IdEst__398D8EEE");
        });

        modelBuilder.Entity<VwTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Total");

            entity.Property(e => e.CentroOrden)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Centro Orden");
            entity.Property(e => e.Conductor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaTanqueo).HasColumnType("datetime");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Responsable)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipCombustible)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Vice)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
