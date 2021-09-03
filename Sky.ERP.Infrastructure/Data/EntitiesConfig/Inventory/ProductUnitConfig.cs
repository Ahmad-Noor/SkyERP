using Microsoft.EntityFrameworkCore;
using Sky.ERP.Domain.Entities.Inventory;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.Inventory
{
    public class ProductUnitConfig : IEntityTypeConfiguration<ProductUnit>
    {
        public void Configure(EntityTypeBuilder<ProductUnit> builder)
        {
            builder.ToTable("ProductUnits");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.ProductId).IsRequired();
            builder.Property(t => t.UnitId).IsRequired(); 
        }
    }
}
