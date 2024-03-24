using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using TraderVoyages.Application.Entities;
using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CityGood> CityGoods { get; set; }
        public DbSet<MountType> MountTypes { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var citiesData = File.ReadAllText("../TraderVoyages.Infrastructure/Data/Seeds/cities.json");
            var cities = JsonConvert.DeserializeObject<List<City>>(citiesData);
            modelBuilder.Entity<City>().HasData(cities);

            var cityGoodsData = File.ReadAllText("../TraderVoyages.Infrastructure/Data/Seeds/citiesGoods.json");
            var cityGoods = JsonConvert.DeserializeObject<List<CityGood>>(cityGoodsData);
            foreach (var cityGood in cityGoods)
            {
                cityGood.Quantity = new Random().Next(100, 201);
            }
            modelBuilder.Entity<CityGood>().HasKey(cg => new { cg.CityID, cg.GoodID });
            modelBuilder.Entity<CityGood>().HasData(cityGoods);



            modelBuilder.Entity<MountType>().HasData(
                new MountType { MountTypeID = 1, Name = "Horse", CarryCapacity = 100, StepCapacity = 60 },
                new MountType { MountTypeID = 2, Name = "Camel", CarryCapacity = 150, StepCapacity = 40 },
                new MountType { MountTypeID = 3, Name = "Elephant", CarryCapacity = 300, StepCapacity = 20 }
            );

            modelBuilder.Entity<Good>().HasData(
                new Good { GoodID = 1, Name = "Wheat", Weight = 3 },
                new Good { GoodID = 2, Name = "Spice", Weight = 7 },
                new Good { GoodID = 3, Name = "Cotton", Weight = 5 },
                new Good { GoodID = 4, Name = "Copper", Weight = 2 }
            );

            modelBuilder.Entity<Player>()
                .Property(p => p.PlayerID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Player>()
                .Property(b => b.Money)
                .HasPrecision(18, 2);

            // PlayerGood ilişkisini tanımla
            modelBuilder.Entity<PlayerGood>()
                .HasKey(pg => new { pg.PlayerID, pg.GoodID });

            modelBuilder.Entity<PlayerGood>()
                .HasOne(pg => pg.Player)
                .WithMany(p => p.PlayerGoods)
                .HasForeignKey(pg => pg.PlayerID);

            modelBuilder.Entity<PlayerGood>()
                .HasOne(pg => pg.Good)
                .WithMany(g => g.PlayerGoods)
                .HasForeignKey(pg => pg.GoodID);

            modelBuilder.Entity<CityGood>()
                .Property(b => b.PurchasePrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<CityGood>()
                .Property(b => b.SalePrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Game>()
                .HasOne<Player>(g => g.Player1)
                .WithMany()
                .HasForeignKey(g => g.Player1Id)
                .OnDelete(DeleteBehavior.NoAction); // Oyuncu silindiğinde oyun silinmez

            modelBuilder.Entity<Game>()
                .HasOne<Player>(g => g.Player2)
                .WithMany()
                .HasForeignKey(g => g.Player2Id)
                .OnDelete(DeleteBehavior.NoAction); // Oyuncu silindiğinde oyun silinmez

        }
    }
}
