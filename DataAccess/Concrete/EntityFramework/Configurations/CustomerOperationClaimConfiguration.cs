using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    internal class CustomerOperationClaimConfiguration : IEntityTypeConfiguration<CustomerOperationClaim>
    {
        public void Configure(EntityTypeBuilder<CustomerOperationClaim> builder)
        {
            builder.ToTable("CustomerOperationClaims", "dbo");
            builder.HasKey(x => x.Id);
        }
    }
}
