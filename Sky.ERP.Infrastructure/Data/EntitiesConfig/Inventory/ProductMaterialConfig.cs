using Microsoft.EntityFrameworkCore;
using Sky.ERP.Domain.Entities.Inventory;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.Inventory
{
    public class ProductMaterialConfig : IEntityTypeConfiguration<ProductMaterial>
    {
        public void Configure(EntityTypeBuilder<ProductMaterial> builder)
        {
            builder.ToTable("ProductMaterials");
            builder.HasKey(o => o.Id); 
        }
    }
}
