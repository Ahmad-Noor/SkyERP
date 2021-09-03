using Microsoft.EntityFrameworkCore;
using Sky.ERP.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sky.ERP.Domain.Entities.GL;

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.GL
{
    public class GLChartConfig : IEntityTypeConfiguration<GLChart>
    {
        public void Configure(EntityTypeBuilder<GLChart> builder)
        {
            builder.ToTable("GLChart");
            builder.HasKey(o => o.Id); 
            builder.Property(t => t.Code).HasMaxLength(10);
            builder.Property(t => t.Name).HasMaxLength(150);

        }
    }
}