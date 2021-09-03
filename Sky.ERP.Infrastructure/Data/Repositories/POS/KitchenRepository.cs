using Sky.ERP.Domain.Entities.POS;

namespace Sky.ERP.Infrastructure.Data.Repositories.POS
{
    public class KitchenRepository : RepositoryBase<Kitchen>, IKitchenRepository
    {
        public KitchenRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
