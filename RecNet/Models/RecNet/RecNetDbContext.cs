using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RecNet.Models.RecNet;

public partial class RecNetDbContext : DbContext
{
    public RecNetDbContext()
    {
    }

    public RecNetDbContext(DbContextOptions<RecNetDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Candidat> Candidats { get; set; }

    public virtual DbSet<Offre> Offres { get; set; }

    public virtual DbSet<Recruteur> Recruteurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:RecNet");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Candidat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Candidat__3214EC07FDCBE48E");

            entity.ToTable("Candidat");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Experience).HasMaxLength(300);
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(50)
                .HasColumnName("Mot De Passe");
            entity.Property(e => e.NomEtPrenom)
                .HasMaxLength(50)
                .HasColumnName("Nom et Prenom");
            entity.Property(e => e.NumTel)
                .HasMaxLength(50)
                .HasColumnName("Num Tel");
            entity.Property(e => e.ParcoursEducatif)
                .HasMaxLength(500)
                .HasColumnName("Parcours Educatif");
        });

        modelBuilder.Entity<Offre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Offre__3214EC072A8895B5");

            entity.ToTable("Offre");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(600)
                .HasColumnName("Description ");
            entity.Property(e => e.IdRecruteur).HasColumnName("Id_Recruteur");
            entity.Property(e => e.Localisation).HasMaxLength(50);
            entity.Property(e => e.Salaire).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.IdRecruteurNavigation).WithMany(p => p.Offres)
                .HasForeignKey(d => d.IdRecruteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Offre__Id_Recrut__286302EC");
        });

        modelBuilder.Entity<Recruteur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Recruteu__3214EC0755BC7C29");

            entity.ToTable("Recruteur");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(50)
                .HasColumnName("Mot De Passe");
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.NumTel).HasMaxLength(12);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
