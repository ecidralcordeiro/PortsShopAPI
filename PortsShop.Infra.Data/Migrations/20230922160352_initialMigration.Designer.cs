﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortsShop.Infra.Data.Context;

#nullable disable

namespace PortsShop.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230922160352_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PortsShop.Domain.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdSku")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdSku");

                    b.HasIndex("IdUser");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SecurityCode")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentType");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Identity")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Passport")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Price", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<double>("CurrentPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateUpdatePrice")
                        .HasColumnType("datetime2");

                    b.Property<double>("OldPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdBranch")
                        .HasColumnType("int");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int");

                    b.Property<int>("IdStore")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdPaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdSKU")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdSKU");

                    b.HasIndex("IdUser");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.SKU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Heigth")
                        .HasColumnType("float");

                    b.Property<int>("IdPrice")
                        .HasColumnType("int");

                    b.Property<int>("IdStock")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weigth")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("SKU");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("stock")
                        .HasColumnType("float");

                    b.Property<string>("typeStock")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CNPJ")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FantasyName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdAdress")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdPerson")
                        .HasColumnType("int");

                    b.Property<int?>("IdStore")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idAdress")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Address", b =>
                {
                    b.HasOne("PortsShop.Domain.Models.Store", null)
                        .WithOne("Address")
                        .HasForeignKey("PortsShop.Domain.Models.Address", "Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("PortsShop.Domain.Models.User", null)
                        .WithOne("Address")
                        .HasForeignKey("PortsShop.Domain.Models.Address", "Id")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Branch", b =>
                {
                    b.HasOne("PortsShop.Domain.Models.Product", null)
                        .WithOne("Branch")
                        .HasForeignKey("PortsShop.Domain.Models.Branch", "Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Cart", b =>
                {
                    b.HasOne("PortsShop.Domain.Models.SKU", "SKU")
                        .WithMany("Carts")
                        .HasForeignKey("IdSku")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PortsShop.Domain.Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("SKU");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Category", b =>
                {
                    b.HasOne("PortsShop.Domain.Models.Product", null)
                        .WithOne("Category")
                        .HasForeignKey("PortsShop.Domain.Models.Category", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Person", b =>
                {
                    b.HasOne("PortsShop.Domain.Models.User", null)
                        .WithOne("Person")
                        .HasForeignKey("PortsShop.Domain.Models.Person", "Id")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Price", b =>
                {
                    b.HasOne("PortsShop.Domain.Models.SKU", null)
                        .WithOne("Price")
                        .HasForeignKey("PortsShop.Domain.Models.Price", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Purchase", b =>
                {
                    b.HasOne("PortsShop.Domain.Models.PaymentType", "PaymentType")
                        .WithOne()
                        .HasForeignKey("PortsShop.Domain.Models.Purchase", "Id");

                    b.HasOne("PortsShop.Domain.Models.SKU", "SKU")
                        .WithMany("Purchases")
                        .HasForeignKey("IdSKU")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PortsShop.Domain.Models.User", "User")
                        .WithMany("Purchases")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PaymentType");

                    b.Navigation("SKU");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Stock", b =>
                {
                    b.HasOne("PortsShop.Domain.Models.SKU", null)
                        .WithOne("Stock")
                        .HasForeignKey("PortsShop.Domain.Models.Stock", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Store", b =>
                {
                    b.HasOne("PortsShop.Domain.Models.Product", null)
                        .WithOne("Store")
                        .HasForeignKey("PortsShop.Domain.Models.Store", "Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PortsShop.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Product", b =>
                {
                    b.Navigation("Branch")
                        .IsRequired();

                    b.Navigation("Category")
                        .IsRequired();

                    b.Navigation("Store")
                        .IsRequired();
                });

            modelBuilder.Entity("PortsShop.Domain.Models.SKU", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Price")
                        .IsRequired();

                    b.Navigation("Purchases");

                    b.Navigation("Stock")
                        .IsRequired();
                });

            modelBuilder.Entity("PortsShop.Domain.Models.Store", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("PortsShop.Domain.Models.User", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Carts");

                    b.Navigation("Person")
                        .IsRequired();

                    b.Navigation("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}