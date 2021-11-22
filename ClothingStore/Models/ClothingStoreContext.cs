using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ClothingStore.Models
{
    public partial class ClothingStoreContext : DbContext
    {
        public ClothingStoreContext()
        {
        }

        public ClothingStoreContext(DbContextOptions<ClothingStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Pembeli> Pembelis { get; set; }
        public virtual DbSet<Produk> Produks { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.ToTable("Invoice");

                entity.Property(e => e.IdOrder)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Order");

                entity.Property(e => e.IdProduk).HasColumnName("ID_Produk");

                entity.Property(e => e.NamaPembeli)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Pembeli");

                entity.Property(e => e.NamaProduk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Produk");

                entity.Property(e => e.NamaSeller)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Seller");

                entity.Property(e => e.TotalHarga).HasColumnName("Total_Harga");
            });

            modelBuilder.Entity<Pembeli>(entity =>
            {
                entity.HasKey(e => e.IdPembeli);

                entity.ToTable("Pembeli");

                entity.Property(e => e.IdPembeli)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Pembeli");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamaPembeli)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Pembeli");

                entity.Property(e => e.NoHp)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("No_HP");
            });

            modelBuilder.Entity<Produk>(entity =>
            {
                entity.HasKey(e => e.IdProduk);

                entity.ToTable("Produk");

                entity.Property(e => e.IdProduk)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Produk");

                entity.Property(e => e.Brand)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NamaProduk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Produk");

                entity.Property(e => e.Ukuran)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.HasKey(e => e.IdSeller);

                entity.ToTable("Seller");

                entity.Property(e => e.IdSeller)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Seller");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamaSeller)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Seller");

                entity.Property(e => e.NoHp)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("No_HP");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
