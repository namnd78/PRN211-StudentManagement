using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Project.Models;

namespace Project.Models
{
    public partial class MyTestContext : DbContext
    {
        public MyTestContext()
        {
        }

        public MyTestContext(DbContextOptions<MyTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KetQua> KetQuas { get; set; } = null!;
        public virtual DbSet<Khoa> Khoas { get; set; } = null!;
        public virtual DbSet<Mon> Mons { get; set; } = null!;
        public virtual DbSet<SinhVien> SinhViens { get; set; } = null!;
        public virtual DbSet<SvthoiHoc> SvthoiHocs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true); IConfigurationRoot configuration = builder.Build(); optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KetQua>(entity =>
            {
                entity.HasKey(e => new { e.MaSo, e.MaMh });

                entity.ToTable("KetQua");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .HasColumnName("MaMH")
                    .IsFixedLength();

                entity.HasOne(d => d.Mon)
                    .WithMany(p => p.KetQuas)
                    .HasForeignKey(d => d.MaMh)
                    .HasConstraintName("FK__KetQua__MaMH__29572725");

                entity.HasOne(d => d.SinhVien)
                    .WithMany(p => p.KetQuas)
                    .HasForeignKey(d => d.MaSo)
                    .HasConstraintName("FK__KetQua__MaSo__2A4B4B5E");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.MaKhoa)
                    .HasName("PK__Khoa__6539040526995FE4");

                entity.ToTable("Khoa");

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.TenKhoa)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mon>(entity =>
            {
                entity.HasKey(e => e.MaMh)
                    .HasName("PK__Mon__2725DFD994E3C7AC");

                entity.ToTable("Mon");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .HasColumnName("MaMH")
                    .IsFixedLength();

                entity.Property(e => e.TenMh)
                    .HasMaxLength(100)
                    .HasColumnName("TenMH")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSo)
                    .HasName("PK__SinhVien__2725087DF1C20B7B");

                entity.ToTable("SinhVien");

                entity.Property(e => e.MaSo).ValueGeneratedNever();

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.DienThoai).HasMaxLength(11);

                entity.Property(e => e.Gpa).HasColumnName("GPA");

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.HasOne(d => d.Khoa)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.MaKhoa)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__SinhVien__MaKhoa__286302EC");
            });

            modelBuilder.Entity<SvthoiHoc>(entity =>
            {
                entity.ToTable("SVThoiHoc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
