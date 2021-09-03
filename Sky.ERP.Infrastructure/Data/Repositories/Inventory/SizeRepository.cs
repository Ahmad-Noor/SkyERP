using Sky.ERP.Domain.Entities.Inventory;

namespace Sky.ERP.Infrastructure.Data.Repositories.Inventory
{
    public class SizeRepository : RepositoryBase<Size>, ISizeRepository
    {
        public SizeRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
