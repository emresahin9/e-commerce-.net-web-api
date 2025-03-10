using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.SeedData
{
    internal class AdminSeedData
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            byte[] passwordHash = new byte[]
            {
                145, 178, 101, 166, 68, 201, 185, 31, 101, 140, 55, 56, 222, 116, 166, 81,
                96, 118, 66, 149, 183, 49, 47, 105, 7, 143, 87, 108, 255, 43, 190, 4,
                212, 80, 242, 42, 109, 49, 248, 255, 211, 67, 84, 51, 55, 226, 202, 119,
                75, 176, 75, 26, 79, 90, 128, 104, 41, 140, 16, 177, 236, 35, 11, 53
            };
            byte[] passwordSalt = new byte[]
            {
                35, 255, 44, 154, 168, 32, 223, 137, 185, 204, 137, 100, 174, 230, 75, 219,
                243, 245, 143, 83, 19, 80, 156, 129, 5, 216, 77, 211, 219, 162, 30, 3, 25,
                14, 90, 143, 170, 81, 8, 98, 127, 213, 242, 130, 90, 4, 108, 141, 175, 150,
                10, 199, 220, 217, 56, 111, 63, 5, 49, 80, 53, 10, 80, 11, 193, 19, 99, 6,
                247, 151, 150, 217, 112, 207, 159, 148, 38, 248, 168, 48, 86, 38, 50, 64,
                118, 233, 142, 40, 117, 152, 90, 53, 141, 185, 118, 143, 231, 111, 199, 103,
                41, 201, 161, 1, 233, 253, 186, 118, 212, 240, 194, 108, 204, 13, 121, 3,
                110, 75, 148, 130, 80, 226, 211, 111, 247, 236, 149, 54
            };
            modelBuilder.Entity<Admin>().HasData(
               new Admin { Id = 1, Email = "admin@admin.com", FirstName = "Admin", LastName = "Admin", PasswordHash = passwordHash, PasswordSalt = passwordSalt }
            );
        }
    }
}
