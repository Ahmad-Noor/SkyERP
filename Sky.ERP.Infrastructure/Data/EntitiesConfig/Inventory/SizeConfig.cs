using Microsoft.EntityFrameworkCore;
using Sky.ERP.Domain.Entities.Inventory;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.Inventory
{
    public class SizeConfig : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.ToTable("Sizes");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Code).HasMaxLength(10);
            builder.Property(t => t.Name).HasMaxLength(150);
            builder.HasData(BuildSeedData());

        }

        private List<Size> BuildSeedData()
        {
            return new List<Size>()  { 
              new Size(){ Id=1,ClientId= 1,BranchId= 1,Code="001",Name= "S" },
              new Size(){ Id=2,ClientId= 1,BranchId= 1,Code="002",Name= "M" },
              new Size(){ Id=3,ClientId= 1,BranchId= 1,Code="003",Name= "L" },
              new Size(){ Id=4,ClientId= 1,BranchId= 1,Code="004",Name= "XL" }
            };
        }
    }
}
