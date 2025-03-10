using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Configurations;
using DataAccess.Concrete.EntityFramework.SeedData;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class ECommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ECommerceDatabase;Trusted_Connection=True");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<AdminOperationClaim> AdminOperationClaims { get; set; }
        public DbSet<CustomerOperationClaim> CustomerOperationClaims { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new OperationClaimConfiguration());
            modelBuilder.ApplyConfiguration(new AdminOperationClaimConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerOperationClaimConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new DistrictConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            new OperationClaimSeedData().Seed(modelBuilder);
            new AdminSeedData().Seed(modelBuilder);
            new AdminOperationClaimSeedData().Seed(modelBuilder);
            new CitySeedData().Seed(modelBuilder);
            new DistrictSeedData().Seed(modelBuilder);
        }
    }
}
