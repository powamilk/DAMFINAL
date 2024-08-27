using System;
using System.Collections.Generic;
using DAMFINAL.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAMFINAL.DAL;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Buoitrogiang> Buoitrogiangs { get; set; }

    public virtual DbSet<Giangvien> Giangviens { get; set; }

    public virtual DbSet<Monhoc> Monhocs { get; set; }

    public virtual DbSet<Trogiang> Trogiangs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=powa;Database=DAM_TestingFinal;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Buoitrogiang>(entity =>
        {
            entity.HasKey(e => e.Mabtg).HasName("PK__BUOITROG__40334CB402F483E9");

            entity.ToTable("BUOITROGIANG");

            entity.Property(e => e.Mabtg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MABTG");
            entity.Property(e => e.Mamh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAMH");
            entity.Property(e => e.Matg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MATG");
            entity.Property(e => e.Sothutu).HasColumnName("SOTHUTU");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MamhNavigation).WithMany(p => p.Buoitrogiangs)
                .HasForeignKey(d => d.Mamh)
                .HasConstraintName("FK__BUOITROGIA__MAMH__3E52440B");

            entity.HasOne(d => d.MatgNavigation).WithMany(p => p.Buoitrogiangs)
                .HasForeignKey(d => d.Matg)
                .HasConstraintName("FK__BUOITROGIA__MATG__3F466844");
        });

        modelBuilder.Entity<Giangvien>(entity =>
        {
            entity.HasKey(e => e.Magv).HasName("PK__GIANGVIE__603F38B1CA4B4F5D");

            entity.ToTable("GIANGVIEN");

            entity.Property(e => e.Magv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAGV");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Ngaysinh).HasColumnName("NGAYSINH");
            entity.Property(e => e.Tengv)
                .HasMaxLength(50)
                .HasColumnName("TENGV");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
        });

        modelBuilder.Entity<Monhoc>(entity =>
        {
            entity.HasKey(e => e.Mamh).HasName("PK__MONHOC__603F69EB79B9A229");

            entity.ToTable("MONHOC");

            entity.Property(e => e.Mamh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAMH");
            entity.Property(e => e.Magv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAGV");
            entity.Property(e => e.Sotinchi).HasColumnName("SOTINCHI");
            entity.Property(e => e.Tenmh)
                .HasMaxLength(50)
                .HasColumnName("TENMH");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MagvNavigation).WithMany(p => p.Monhocs)
                .HasForeignKey(d => d.Magv)
                .HasConstraintName("FK__MONHOC__MAGV__398D8EEE");
        });

        modelBuilder.Entity<Trogiang>(entity =>
        {
            entity.HasKey(e => e.Matg).HasName("PK__TROGIANG__6023721A04351D37");

            entity.ToTable("TROGIANG");

            entity.Property(e => e.Matg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MATG");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Ngaysinh).HasColumnName("NGAYSINH");
            entity.Property(e => e.Tentg)
                .HasMaxLength(50)
                .HasColumnName("TENTG");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
