using Microsoft.EntityFrameworkCore;
using Sky.ERP.Domain.Entities.Inventory;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.Inventory
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Code).HasMaxLength(10);
            builder.Property(t => t.Name).HasMaxLength(150); 
            builder.Property(t => t.Description).HasMaxLength(250);
            builder.Property(t => t.Barcode).HasMaxLength(150);
            builder.Property(t => t.ImageURL).HasMaxLength(500); 
        }
    }
}
