using Microsoft.EntityFrameworkCore;
using Sky.ERP.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.Common
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Street).HasMaxLength(150);
            builder.Property(t => t.PostalCode).HasMaxLength(15);

        }
    }
}