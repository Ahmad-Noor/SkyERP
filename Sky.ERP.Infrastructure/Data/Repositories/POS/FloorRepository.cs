using Sky.ERP.Domain.Entities.POS;

namespace Sky.ERP.Infrastructure.Data.Repositories.POS
{
    public class FloorRepository : RepositoryBase<Floor>, IFloorRepository
    {
        public FloorRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
