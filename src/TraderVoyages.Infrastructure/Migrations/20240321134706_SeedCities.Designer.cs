﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TraderVoyages.Infrastructure.Data;

#nullable disable

namespace TraderVoyages.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240321134706_SeedCities")]
    partial class SeedCities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TraderVoyages.Domain.Entities.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("XCoordinate")
                        .HasColumnType("int");

                    b.Property<int>("YCoordinate")
                        .HasColumnType("int");

                    b.HasKey("CityID");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityID = 1,
                            Name = "Quixotica",
                            XCoordinate = 10,
                            YCoordinate = 20
                        },
                        new
                        {
                            CityID = 2,
                            Name = "Avalonia",
                            XCoordinate = 30,
                            YCoordinate = 40
                        },
                        new
                        {
                            CityID = 3,
                            Name = "Eldorado",
                            XCoordinate = 50,
                            YCoordinate = 60
                        },
                        new
                        {
                            CityID = 4,
                            Name = "Atlantis",
                            XCoordinate = 70,
                            YCoordinate = 80
                        },
                        new
                        {
                            CityID = 5,
                            Name = "Shangri-La",
                            XCoordinate = 90,
                            YCoordinate = 100
                        },
                        new
                        {
                            CityID = 6,
                            Name = "Xanadu",
                            XCoordinate = 110,
                            YCoordinate = 120
                        },
                        new
                        {
                            CityID = 7,
                            Name = "Narnia",
                            XCoordinate = 130,
                            YCoordinate = 140
                        },
                        new
                        {
                            CityID = 8,
                            Name = "Hogwarts",
                            XCoordinate = 150,
                            YCoordinate = 160
                        },
                        new
                        {
                            CityID = 9,
                            Name = "Neverland",
                            XCoordinate = 170,
                            YCoordinate = 180
                        },
                        new
                        {
                            CityID = 10,
                            Name = "Gotham",
                            XCoordinate = 190,
                            YCoordinate = 200
                        });
                });

            modelBuilder.Entity("TraderVoyages.Domain.Entities.CityGood", b =>
                {
                    b.Property<int>("CityGoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityGoodID"));

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<int>("GoodID")
                        .HasColumnType("int");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CityGoodID");

                    b.HasIndex("CityID");

                    b.HasIndex("GoodID");

                    b.ToTable("CityGoods");
                });

            modelBuilder.Entity("TraderVoyages.Domain.Entities.Good", b =>
                {
                    b.Property<int>("GoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoodID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalCount")
                        .HasColumnType("int");

                    b.HasKey("GoodID");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("TraderVoyages.Domain.Entities.MountType", b =>
                {
                    b.Property<int>("MountTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MountTypeID"));

                    b.Property<int>("CarryCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StepCapacity")
                        .HasColumnType("int");

                    b.HasKey("MountTypeID");

                    b.ToTable("MountTypes");
                });

            modelBuilder.Entity("TraderVoyages.Domain.Entities.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerID"));

                    b.Property<int>("CurrentCityID")
                        .HasColumnType("int");

                    b.Property<decimal>("Money")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MountTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("XCoordinate")
                        .HasColumnType("int");

                    b.Property<int>("YCoordinate")
                        .HasColumnType("int");

                    b.HasKey("PlayerID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("TraderVoyages.Domain.Entities.CityGood", b =>
                {
                    b.HasOne("TraderVoyages.Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraderVoyages.Domain.Entities.Good", "Good")
                        .WithMany()
                        .HasForeignKey("GoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Good");
                });
#pragma warning restore 612, 618
        }
    }
}