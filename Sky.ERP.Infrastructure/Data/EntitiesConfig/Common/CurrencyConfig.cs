using Microsoft.EntityFrameworkCore;
using Sky.ERP.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.Common
{
    public class CurrencyConfig : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.ToTable("Currencies");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Code).HasMaxLength(10);
            builder.Property(t => t.Name).HasMaxLength(150);


        }
    }
}
