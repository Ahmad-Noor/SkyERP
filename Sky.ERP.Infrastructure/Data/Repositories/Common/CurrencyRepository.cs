using Sky.ERP.Domain.Entities.Common;

namespace Sky.ERP.Infrastructure.Data.Repositories.Common
{
    public class CurrencyRepository : RepositoryBase<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
