using Sky.ERP.Domain.Entities.Inventory;

namespace Sky.ERP.Infrastructure.Data.Repositories.Inventory
{
    public class UnitRepository : RepositoryBase<Unit>, IUnitRepository
    {
        public UnitRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
