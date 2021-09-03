using Sky.ERP.Domain.Entities.POS;

namespace Sky.ERP.Infrastructure.Data.Repositories.POS
{
    public class TableRepository : RepositoryBase<Table>, ITableRepository
    {
        public TableRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
