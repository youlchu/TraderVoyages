﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TraderVoyages.Infrastructure.Data;

#nullable disable

namespace TraderVoyages.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TraderVoyages.Application.Entities.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Player1Id")
                        .HasColumnType("int");

                    b.Property<int>("Player2Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TurnId")
                        .HasColumnType("int");

                    b.HasKey("GameId");

                    b.HasIndex("Player1Id");

                    b.HasIndex("Player2Id");

                    b.ToTable("Games");
                });

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
                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<int>("GoodID")
                        .HasColumnType("int");

                    b.Property<int>("CityGoodID")
                        .HasColumnType("int");

                    b.Property<decimal>("PurchasePrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("SalePrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CityID", "GoodID");

                    b.HasIndex("GoodID");

                    b.ToTable("CityGoods");

                    b.HasData(
                        new
                        {
                            CityID = 1,
                            GoodID = 1,
                            CityGoodID = 1,
                            PurchasePrice = 20m,
                            Quantity = 147,
                            SalePrice = 25m
                        },
                        new
                        {
                            CityID = 1,
                            GoodID = 2,
                            CityGoodID = 2,
                            PurchasePrice = 30m,
                            Quantity = 143,
                            SalePrice = 35m
                        },
                        new
                        {
                            CityID = 1,
                            GoodID = 3,
                            CityGoodID = 3,
                            PurchasePrice = 25m,
                            Quantity = 141,
                            SalePrice = 30m
                        },
                        new
                        {
                            CityID = 1,
                            GoodID = 4,
                            CityGoodID = 4,
                            PurchasePrice = 15m,
                            Quantity = 153,
                            SalePrice = 20m
                        },
                        new
                        {
                            CityID = 2,
                            GoodID = 1,
                            CityGoodID = 5,
                            PurchasePrice = 22m,
                            Quantity = 143,
                            SalePrice = 27m
                        },
                        new
                        {
                            CityID = 2,
                            GoodID = 2,
                            CityGoodID = 6,
                            PurchasePrice = 32m,
                            Quantity = 148,
                            SalePrice = 37m
                        },
                        new
                        {
                            CityID = 2,
                            GoodID = 3,
                            CityGoodID = 7,
                            PurchasePrice = 27m,
                            Quantity = 183,
                            SalePrice = 32m
                        },
                        new
                        {
                            CityID = 2,
                            GoodID = 4,
                            CityGoodID = 8,
                            PurchasePrice = 17m,
                            Quantity = 125,
                            SalePrice = 22m
                        },
                        new
                        {
                            CityID = 3,
                            GoodID = 1,
                            CityGoodID = 9,
                            PurchasePrice = 24m,
                            Quantity = 115,
                            SalePrice = 29m
                        },
                        new
                        {
                            CityID = 3,
                            GoodID = 2,
                            CityGoodID = 10,
                            PurchasePrice = 34m,
                            Quantity = 160,
                            SalePrice = 39m
                        },
                        new
                        {
                            CityID = 3,
                            GoodID = 3,
                            CityGoodID = 11,
                            PurchasePrice = 29m,
                            Quantity = 179,
                            SalePrice = 34m
                        },
                        new
                        {
                            CityID = 3,
                            GoodID = 4,
                            CityGoodID = 12,
                            PurchasePrice = 19m,
                            Quantity = 198,
                            SalePrice = 24m
                        },
                        new
                        {
                            CityID = 4,
                            GoodID = 1,
                            CityGoodID = 13,
                            PurchasePrice = 26m,
                            Quantity = 171,
                            SalePrice = 31m
                        },
                        new
                        {
                            CityID = 4,
                            GoodID = 2,
                            CityGoodID = 14,
                            PurchasePrice = 36m,
                            Quantity = 111,
                            SalePrice = 41m
                        },
                        new
                        {
                            CityID = 4,
                            GoodID = 3,
                            CityGoodID = 15,
                            PurchasePrice = 31m,
                            Quantity = 160,
                            SalePrice = 36m
                        },
                        new
                        {
                            CityID = 4,
                            GoodID = 4,
                            CityGoodID = 16,
                            PurchasePrice = 21m,
                            Quantity = 151,
                            SalePrice = 26m
                        },
                        new
                        {
                            CityID = 5,
                            GoodID = 1,
                            CityGoodID = 17,
                            PurchasePrice = 28m,
                            Quantity = 155,
                            SalePrice = 33m
                        },
                        new
                        {
                            CityID = 5,
                            GoodID = 2,
                            CityGoodID = 18,
                            PurchasePrice = 38m,
                            Quantity = 108,
                            SalePrice = 43m
                        },
                        new
                        {
                            CityID = 5,
                            GoodID = 3,
                            CityGoodID = 19,
                            PurchasePrice = 33m,
                            Quantity = 104,
                            SalePrice = 38m
                        },
                        new
                        {
                            CityID = 5,
                            GoodID = 4,
                            CityGoodID = 20,
                            PurchasePrice = 23m,
                            Quantity = 104,
                            SalePrice = 28m
                        },
                        new
                        {
                            CityID = 6,
                            GoodID = 1,
                            CityGoodID = 21,
                            PurchasePrice = 30m,
                            Quantity = 110,
                            SalePrice = 35m
                        },
                        new
                        {
                            CityID = 6,
                            GoodID = 2,
                            CityGoodID = 22,
                            PurchasePrice = 40m,
                            Quantity = 104,
                            SalePrice = 45m
                        },
                        new
                        {
                            CityID = 6,
                            GoodID = 3,
                            CityGoodID = 23,
                            PurchasePrice = 35m,
                            Quantity = 200,
                            SalePrice = 40m
                        },
                        new
                        {
                            CityID = 6,
                            GoodID = 4,
                            CityGoodID = 24,
                            PurchasePrice = 25m,
                            Quantity = 196,
                            SalePrice = 30m
                        },
                        new
                        {
                            CityID = 7,
                            GoodID = 1,
                            CityGoodID = 25,
                            PurchasePrice = 32m,
                            Quantity = 137,
                            SalePrice = 37m
                        },
                        new
                        {
                            CityID = 7,
                            GoodID = 2,
                            CityGoodID = 26,
                            PurchasePrice = 42m,
                            Quantity = 149,
                            SalePrice = 47m
                        },
                        new
                        {
                            CityID = 7,
                            GoodID = 3,
                            CityGoodID = 27,
                            PurchasePrice = 37m,
                            Quantity = 156,
                            SalePrice = 42m
                        },
                        new
                        {
                            CityID = 7,
                            GoodID = 4,
                            CityGoodID = 28,
                            PurchasePrice = 27m,
                            Quantity = 113,
                            SalePrice = 32m
                        },
                        new
                        {
                            CityID = 8,
                            GoodID = 1,
                            CityGoodID = 29,
                            PurchasePrice = 34m,
                            Quantity = 147,
                            SalePrice = 39m
                        },
                        new
                        {
                            CityID = 8,
                            GoodID = 2,
                            CityGoodID = 30,
                            PurchasePrice = 44m,
                            Quantity = 133,
                            SalePrice = 49m
                        },
                        new
                        {
                            CityID = 8,
                            GoodID = 3,
                            CityGoodID = 31,
                            PurchasePrice = 39m,
                            Quantity = 106,
                            SalePrice = 44m
                        },
                        new
                        {
                            CityID = 8,
                            GoodID = 4,
                            CityGoodID = 32,
                            PurchasePrice = 29m,
                            Quantity = 171,
                            SalePrice = 34m
                        },
                        new
                        {
                            CityID = 9,
                            GoodID = 1,
                            CityGoodID = 33,
                            PurchasePrice = 36m,
                            Quantity = 174,
                            SalePrice = 41m
                        },
                        new
                        {
                            CityID = 9,
                            GoodID = 2,
                            CityGoodID = 34,
                            PurchasePrice = 46m,
                            Quantity = 171,
                            SalePrice = 51m
                        },
                        new
                        {
                            CityID = 9,
                            GoodID = 3,
                            CityGoodID = 35,
                            PurchasePrice = 41m,
                            Quantity = 158,
                            SalePrice = 46m
                        },
                        new
                        {
                            CityID = 9,
                            GoodID = 4,
                            CityGoodID = 36,
                            PurchasePrice = 31m,
                            Quantity = 155,
                            SalePrice = 36m
                        },
                        new
                        {
                            CityID = 10,
                            GoodID = 1,
                            CityGoodID = 37,
                            PurchasePrice = 38m,
                            Quantity = 180,
                            SalePrice = 43m
                        },
                        new
                        {
                            CityID = 10,
                            GoodID = 2,
                            CityGoodID = 38,
                            PurchasePrice = 48m,
                            Quantity = 190,
                            SalePrice = 53m
                        },
                        new
                        {
                            CityID = 10,
                            GoodID = 3,
                            CityGoodID = 39,
                            PurchasePrice = 43m,
                            Quantity = 101,
                            SalePrice = 48m
                        },
                        new
                        {
                            CityID = 10,
                            GoodID = 4,
                            CityGoodID = 40,
                            PurchasePrice = 33m,
                            Quantity = 111,
                            SalePrice = 38m
                        });
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

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("GoodID");

                    b.ToTable("Goods");

                    b.HasData(
                        new
                        {
                            GoodID = 1,
                            Name = "Wheat",
                            Weight = 3
                        },
                        new
                        {
                            GoodID = 2,
                            Name = "Spice",
                            Weight = 7
                        },
                        new
                        {
                            GoodID = 3,
                            Name = "Cotton",
                            Weight = 5
                        },
                        new
                        {
                            GoodID = 4,
                            Name = "Copper",
                            Weight = 2
                        });
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

                    b.HasData(
                        new
                        {
                            MountTypeID = 1,
                            CarryCapacity = 100,
                            Name = "Horse",
                            StepCapacity = 60
                        },
                        new
                        {
                            MountTypeID = 2,
                            CarryCapacity = 150,
                            Name = "Camel",
                            StepCapacity = 40
                        },
                        new
                        {
                            MountTypeID = 3,
                            CarryCapacity = 300,
                            Name = "Elephant",
                            StepCapacity = 20
                        });
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
                        .HasPrecision(18, 2)
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

            modelBuilder.Entity("TraderVoyages.Domain.Entities.PlayerGood", b =>
                {
                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<int>("GoodID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("PlayerID", "GoodID");

                    b.HasIndex("GoodID");

                    b.ToTable("PlayerGood");
                });

            modelBuilder.Entity("TraderVoyages.Application.Entities.Game", b =>
                {
                    b.HasOne("TraderVoyages.Domain.Entities.Player", "Player1")
                        .WithMany()
                        .HasForeignKey("Player1Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TraderVoyages.Domain.Entities.Player", "Player2")
                        .WithMany()
                        .HasForeignKey("Player2Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Player1");

                    b.Navigation("Player2");
                });

            modelBuilder.Entity("TraderVoyages.Domain.Entities.CityGood", b =>
                {
                    b.HasOne("TraderVoyages.Domain.Entities.City", "City")
                        .WithMany("CityGoods")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraderVoyages.Domain.Entities.Good", "Good")
                        .WithMany("CityGoods")
                        .HasForeignKey("GoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Good");
                });

            modelBuilder.Entity("TraderVoyages.Domain.Entities.PlayerGood", b =>
                {
                    b.HasOne("TraderVoyages.Domain.Entities.Good", "Good")
                        .WithMany("PlayerGoods")
                        .HasForeignKey("GoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraderVoyages.Domain.Entities.Player", "Player")
                        .WithMany("PlayerGoods")
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Good");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("TraderVoyages.Domain.Entities.City", b =>
                {
                    b.Navigation("CityGoods");
                });

            modelBuilder.Entity("TraderVoyages.Domain.Entities.Good", b =>
                {
                    b.Navigation("CityGoods");

                    b.Navigation("PlayerGoods");
                });

            modelBuilder.Entity("TraderVoyages.Domain.Entities.Player", b =>
                {
                    b.Navigation("PlayerGoods");
                });
#pragma warning restore 612, 618
        }
    }
}
