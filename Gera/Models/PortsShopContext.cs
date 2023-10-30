using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GeraClasse.Models;

public partial class PortsShopContext : DbContext
{
    public PortsShopContext()
    {
    }

    public PortsShopContext(DbContextOptions<PortsShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<PaymentType> PaymentTypes { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Price> Prices { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    public virtual DbSet<Sku> Skus { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-BGBRU8F\\CAPZME;database=PortsShop;user=sa;password=root;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.Region).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.Street).HasMaxLength(255);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Address)
                .HasForeignKey<Address>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Id1).WithOne(p => p.Address)
                .HasForeignKey<Address>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("Branch");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.ToTable("Cart");

            entity.HasIndex(e => e.IdSku, "IX_Cart_IdSku");

            entity.HasIndex(e => e.IdUser, "IX_Cart_IdUser");

            entity.HasOne(d => d.IdSkuNavigation).WithMany(p => p.Carts)
                .HasForeignKey(d => d.IdSku)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Carts)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<PaymentType>(entity =>
        {
            entity.ToTable("PaymentType");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("Person");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .HasColumnName("CPF");
            entity.Property(e => e.Identity).HasMaxLength(30);
            entity.Property(e => e.Passport).HasMaxLength(30);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Person)
                .HasForeignKey<Person>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Price>(entity =>
        {
            entity.ToTable("Price");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Price)
                .HasForeignKey<Price>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity.ToTable("Purchase");

            entity.HasIndex(e => e.IdSku, "IX_Purchase_IdSKU");

            entity.HasIndex(e => e.IdUser, "IX_Purchase_IdUser");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Date).HasColumnName("DATE");
            entity.Property(e => e.IdSku).HasColumnName("IdSKU");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Purchase)
                .HasForeignKey<Purchase>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdSkuNavigation).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.IdSku)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Sku>(entity =>
        {
            entity.ToTable("SKU");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.ToTable("Stock");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Stock1).HasColumnName("stock");
            entity.Property(e => e.TypeStock)
                .HasMaxLength(20)
                .HasColumnName("typeStock");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Stock)
                .HasForeignKey<Stock>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.ToTable("Store");

            entity.HasIndex(e => e.UserId, "IX_Store_UserId");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .HasColumnName("CNPJ");
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.FantasyName).HasMaxLength(50);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Store)
                .HasForeignKey<Store>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.Stores).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.IdAdress).HasColumnName("idAdress");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
