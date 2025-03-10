using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.SeedData
{
    internal class DistrictSeedData
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>().HasData(
               new District { Id = 1, Name = "Ataşehir", CityId = 1 },
               new District { Id = 2, Name = "Üsküdar", CityId = 1 },
               new District { Id = 3, Name = "Ümraniye", CityId = 1 },
               new District { Id = 4, Name = "Beşikteş", CityId = 1 },
               new District { Id = 5, Name = "Şişli", CityId = 1 },
               new District { Id = 6, Name = "İzmit", CityId = 2 },
               new District { Id = 7, Name = "Körfez", CityId = 2 },
               new District { Id = 8, Name = "Gebze", CityId = 2 },
               new District { Id = 9, Name = "Derince", CityId = 2 },
               new District { Id = 10, Name = "Gölcük", CityId = 2 },
               new District { Id = 11, Name = "Nilüfer", CityId = 3 },
               new District { Id = 12, Name = "Yıldırım", CityId = 3 },
               new District { Id = 13, Name = "Osmangazi", CityId = 3 },
               new District { Id = 14, Name = "Gemlik", CityId = 3 },
               new District { Id = 15, Name = "Mudanya", CityId = 3 }
            );
        }
    }
}
