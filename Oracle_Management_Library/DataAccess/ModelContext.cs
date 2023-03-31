using Microsoft.EntityFrameworkCore;
using Oracle_Management_Library.Models;
using System.Configuration;

namespace Oracle_Management_Library.DataAccess;

public partial class ModelContext : DbContext
{


    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dean> Deans { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phancong> Phancongs { get; set; }

    public virtual DbSet<Phongban> Phongbans { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseOracle(ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("MY_PROJECT_PLUG_USER")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Dean>(entity =>
        {
            entity.HasKey(e => e.Mada).HasName("SYS_C008221");

            entity.ToTable("DEAN");

            entity.Property(e => e.Mada)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MADA");
            entity.Property(e => e.Mapb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAPB");
            entity.Property(e => e.Ngaybd)
                .HasColumnType("DATE")
                .HasColumnName("NGAYBD");
            entity.Property(e => e.Tenda)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TENDA");

            entity.HasOne(d => d.MapbNavigation).WithMany(p => p.Deans)
                .HasForeignKey(d => d.Mapb)
                .HasConstraintName("FK_DA_PB");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv).HasName("SYS_C008229");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MANV");
            entity.Property(e => e.Diachi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Luong)
                .HasColumnType("FLOAT")
                .HasColumnName("LUONG");
            entity.Property(e => e.Manql)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MANQL");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("DATE")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Phai)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PHAI");
            entity.Property(e => e.Phg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PHG");
            entity.Property(e => e.Phucap)
                .HasColumnType("FLOAT")
                .HasColumnName("PHUCAP");
            entity.Property(e => e.Sodt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SODT");
            entity.Property(e => e.Tennv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TENNV");
            entity.Property(e => e.Vaitro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("VAITRO");

            entity.HasOne(d => d.ManqlNavigation).WithMany(p => p.InverseManqlNavigation)
                .HasForeignKey(d => d.Manql)
                .HasConstraintName("FK_NV_NV");

            entity.HasOne(d => d.PhgNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Phg)
                .HasConstraintName("FK_NV_PB");
        });

        modelBuilder.Entity<Phancong>(entity =>
        {
            entity.HasKey(e => new { e.Manv, e.Mada });

            entity.ToTable("PHANCONG");

            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MANV");
            entity.Property(e => e.Mada)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MADA");
            entity.Property(e => e.Thoigian)
                .HasColumnType("DATE")
                .HasColumnName("THOIGIAN");

            entity.HasOne(d => d.MadaNavigation).WithMany(p => p.Phancongs)
                .HasForeignKey(d => d.Mada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PC_DA");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Phancongs)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PC_NV");
        });

        modelBuilder.Entity<Phongban>(entity =>
        {
            entity.HasKey(e => e.Mapb).HasName("SYS_C008220");

            entity.ToTable("PHONGBAN");

            entity.Property(e => e.Mapb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAPB");
            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MANV");
            entity.Property(e => e.Tenpb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TENPB");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Phongbans)
                .HasForeignKey(d => d.Manv)
                .HasConstraintName("FK_PB_NV");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
