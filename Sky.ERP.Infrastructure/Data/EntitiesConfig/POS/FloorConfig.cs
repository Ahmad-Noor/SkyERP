using Sky.ERP.Domain.Entities.POS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.POS
{
    public class FloorConfig : IEntityTypeConfiguration<Floor>
    {
        public void Configure(EntityTypeBuilder<Floor> builder)
        {
            builder.ToTable("Floors",schema:"POS");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Code).HasMaxLength(10);
            builder.Property(t => t.Name).HasMaxLength(150);  
            builder.Property(t => t.ImageURL).HasMaxLength(500); 
        }
    }
}
