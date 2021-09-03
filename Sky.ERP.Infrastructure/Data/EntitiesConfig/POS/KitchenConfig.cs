using Sky.ERP.Domain.Entities.POS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.POS
{
    public class KitchenConfig : IEntityTypeConfiguration<Kitchen>
    {
        public void Configure(EntityTypeBuilder<Kitchen> builder)
        {
            builder.ToTable("Kitchens",schema:"POS");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Code).HasMaxLength(10);
            builder.Property(t => t.Name).HasMaxLength(150);   
        }
    }
}
