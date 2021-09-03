using Microsoft.EntityFrameworkCore;
using Sky.ERP.Domain.Entities.Inventory;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.Inventory
{
    public class UnitConfig : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.ToTable("Units");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Code).HasMaxLength(10);
            builder.Property(t => t.Name).HasMaxLength(150);
            builder.HasData(BuildSeedData());

        }

        private List<Unit> BuildSeedData()
        {
            return new List<Unit>()  {
              new Unit(){ Id=1,ClientId= 1,BranchId= 1,Code="001",Name= "Unit" },
              new Unit(){ Id=2,ClientId= 1,BranchId= 1,Code="002",Name= "kilogram" },
              new Unit(){ Id=3,ClientId= 1,BranchId= 1,Code="003",Name= "Piece" },
              new Unit(){ Id=4,ClientId= 1,BranchId= 1,Code="004",Name= "Package" }
            };
        }
    }
}
