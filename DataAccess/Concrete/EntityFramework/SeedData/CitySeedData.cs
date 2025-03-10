using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.SeedData
{
    internal class CitySeedData
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
               new City { Id = 1, Name = "İstanbul" },
               new City { Id = 2, Name = "Kocaeli" },
               new City { Id = 3, Name = "Bursa" }
            );
        }
    }
}
