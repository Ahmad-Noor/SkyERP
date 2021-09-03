using Microsoft.EntityFrameworkCore;
using Sky.ERP.Domain.Entities.Inventory;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.Inventory
{
    public class ProductSizeConfig : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder.ToTable("ProductSizes");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.ProductId).IsRequired();
            builder.Property(t => t.SizeId).IsRequired(); 
        }
    }
}
