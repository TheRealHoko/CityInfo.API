using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City("Paris")
                {
                    Id = 1,
                    Description = "The city of love and baguette.",
                },
                new City("London")
                {
                    Id = 2,
                    Description = "Fish and Chips all day long.",
                },
                new City("New York")
                {
                    Id = 3,
                    Description = "The Big Apple just a mouth away.",
                });
            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest("Louvre")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "The Famous Museum in Paris."
                },
                new PointOfInterest("Eiffel Tower")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "The Famous Metallic Tower of Paris."
                },
                new PointOfInterest("The Big Eye")
                {
                    Id = 3,
                    CityId = 2,
                    Description = "The wheel of South Bank."
                },
                new PointOfInterest("The Big Ben")
                {
                    Id = 4,
                    CityId = 2,
                    Description = "The striking clock of the Palace of Westminster."
                },
                new PointOfInterest("Broadway Theatre")
                {
                    Id = 5,
                    CityId = 3,
                    Description = "The most famous theatre in the world."
                },
                new PointOfInterest("Madison Square")
                {
                    Id = 6,
                    CityId = 3,
                    Description = "A square full of lights which the fame came from."
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
