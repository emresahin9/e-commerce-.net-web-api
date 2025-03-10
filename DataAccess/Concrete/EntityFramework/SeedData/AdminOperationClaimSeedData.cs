using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.SeedData
{
    internal class AdminOperationClaimSeedData
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminOperationClaim>().HasData(
               new AdminOperationClaim { Id = 1, AdminId = 1, OperationClaimId = 1 }
            );
        }
    }
}
