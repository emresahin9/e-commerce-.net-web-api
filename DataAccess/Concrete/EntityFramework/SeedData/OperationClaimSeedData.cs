using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.SeedData
{
    internal class OperationClaimSeedData
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperationClaim>().HasData(
               new OperationClaim { Id = 1, Name = "admin" },
               new OperationClaim { Id = 2, Name = "customer" }
            );
        }
    }
}
