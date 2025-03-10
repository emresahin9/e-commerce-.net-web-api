using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    internal class AdminOperationClaimConfiguration : IEntityTypeConfiguration<AdminOperationClaim>
    {
        public void Configure(EntityTypeBuilder<AdminOperationClaim> builder)
        {
            builder.ToTable("AdminOperationClaims", "dbo");
            builder.HasKey(x => x.Id);
        }
    }
}
