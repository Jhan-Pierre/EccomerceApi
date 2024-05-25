﻿// <auto-generated />
using System;
using EccomerceApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EccomerceApi.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    [Migration("20240525164101_AddProductCategoriesByGama")]
    partial class AddProductCategoriesByGama
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EccomerceApi.Entity.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdState")
                        .HasColumnType("int");

                    b.Property<int?>("IdStateNavigationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdStateNavigationId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("EccomerceApi.Entity.EntryDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("IdEntry")
                        .HasColumnType("int");

                    b.Property<int?>("IdEntryNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int?>("IdProductNavigationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("UnitCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdEntryNavigationId");

                    b.HasIndex("IdProductNavigationId");

                    b.ToTable("EntryDetails");
                });

            modelBuilder.Entity("EccomerceApi.Entity.Loss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdState")
                        .HasColumnType("int");

                    b.Property<int?>("IdStateNavigationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdStateNavigationId");

                    b.ToTable("Losses");
                });

            modelBuilder.Entity("EccomerceApi.Entity.LostDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("IdLoss")
                        .HasColumnType("int");

                    b.Property<int?>("IdLossNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int?>("IdProductNavigationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("UnitCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdLossNavigationId");

                    b.HasIndex("IdProductNavigationId");

                    b.ToTable("LostDetails");
                });

            modelBuilder.Entity("EccomerceApi.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Existence")
                        .HasColumnType("int");

                    b.Property<int?>("IdProductCategory")
                        .HasColumnType("int");

                    b.Property<int?>("IdState")
                        .HasColumnType("int");

                    b.Property<int?>("IdStateNavigationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductBrandId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdProductCategory");

                    b.HasIndex("IdStateNavigationId");

                    b.HasIndex("ProductBrandId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EccomerceApi.Entity.ProductBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductBrand");
                });

            modelBuilder.Entity("EccomerceApi.Entity.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gama Baja"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Gama Media"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Gama Alta"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gama Top"
                        });
                });

            modelBuilder.Entity("EccomerceApi.Entity.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdState")
                        .HasColumnType("int");

                    b.Property<int?>("IdStateNavigationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdStateNavigationId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("EccomerceApi.Entity.SaleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int?>("IdProductNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("IdSale")
                        .HasColumnType("int");

                    b.Property<int?>("IdSaleNavigationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("UnitCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdProductNavigationId");

                    b.HasIndex("IdSaleNavigationId");

                    b.ToTable("SaleDetails");
                });

            modelBuilder.Entity("EccomerceApi.Entity.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EccomerceApi.Entity.Entry", b =>
                {
                    b.HasOne("EccomerceApi.Entity.State", "IdStateNavigation")
                        .WithMany("Entries")
                        .HasForeignKey("IdStateNavigationId");

                    b.Navigation("IdStateNavigation");
                });

            modelBuilder.Entity("EccomerceApi.Entity.EntryDetail", b =>
                {
                    b.HasOne("EccomerceApi.Entity.Entry", "IdEntryNavigation")
                        .WithMany("EntryDetails")
                        .HasForeignKey("IdEntryNavigationId");

                    b.HasOne("EccomerceApi.Entity.Product", "IdProductNavigation")
                        .WithMany("EntryDetails")
                        .HasForeignKey("IdProductNavigationId");

                    b.Navigation("IdEntryNavigation");

                    b.Navigation("IdProductNavigation");
                });

            modelBuilder.Entity("EccomerceApi.Entity.Loss", b =>
                {
                    b.HasOne("EccomerceApi.Entity.State", "IdStateNavigation")
                        .WithMany("Losses")
                        .HasForeignKey("IdStateNavigationId");

                    b.Navigation("IdStateNavigation");
                });

            modelBuilder.Entity("EccomerceApi.Entity.LostDetail", b =>
                {
                    b.HasOne("EccomerceApi.Entity.Loss", "IdLossNavigation")
                        .WithMany("LostDetails")
                        .HasForeignKey("IdLossNavigationId");

                    b.HasOne("EccomerceApi.Entity.Product", "IdProductNavigation")
                        .WithMany("LostDetails")
                        .HasForeignKey("IdProductNavigationId");

                    b.Navigation("IdLossNavigation");

                    b.Navigation("IdProductNavigation");
                });

            modelBuilder.Entity("EccomerceApi.Entity.Product", b =>
                {
                    b.HasOne("EccomerceApi.Entity.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("IdProductCategory");

                    b.HasOne("EccomerceApi.Entity.State", "IdStateNavigation")
                        .WithMany("Products")
                        .HasForeignKey("IdStateNavigationId");

                    b.HasOne("EccomerceApi.Entity.ProductBrand", "ProductBrand")
                        .WithMany()
                        .HasForeignKey("ProductBrandId");

                    b.Navigation("IdStateNavigation");

                    b.Navigation("ProductBrand");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("EccomerceApi.Entity.Sale", b =>
                {
                    b.HasOne("EccomerceApi.Entity.State", "IdStateNavigation")
                        .WithMany("Sales")
                        .HasForeignKey("IdStateNavigationId");

                    b.Navigation("IdStateNavigation");
                });

            modelBuilder.Entity("EccomerceApi.Entity.SaleDetail", b =>
                {
                    b.HasOne("EccomerceApi.Entity.Product", "IdProductNavigation")
                        .WithMany("SaleDetails")
                        .HasForeignKey("IdProductNavigationId");

                    b.HasOne("EccomerceApi.Entity.Sale", "IdSaleNavigation")
                        .WithMany("SaleDetails")
                        .HasForeignKey("IdSaleNavigationId");

                    b.Navigation("IdProductNavigation");

                    b.Navigation("IdSaleNavigation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EccomerceApi.Entity.Entry", b =>
                {
                    b.Navigation("EntryDetails");
                });

            modelBuilder.Entity("EccomerceApi.Entity.Loss", b =>
                {
                    b.Navigation("LostDetails");
                });

            modelBuilder.Entity("EccomerceApi.Entity.Product", b =>
                {
                    b.Navigation("EntryDetails");

                    b.Navigation("LostDetails");

                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("EccomerceApi.Entity.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EccomerceApi.Entity.Sale", b =>
                {
                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("EccomerceApi.Entity.State", b =>
                {
                    b.Navigation("Entries");

                    b.Navigation("Losses");

                    b.Navigation("Products");

                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
