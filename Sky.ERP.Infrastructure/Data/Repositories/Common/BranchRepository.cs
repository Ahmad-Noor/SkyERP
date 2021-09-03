using Sky.ERP.Domain.Entities.Common;

namespace Sky.ERP.Infrastructure.Data.Repositories.Common
{
    public class BranchRepository : RepositoryBase<Branch>, IBranchRepository
    {
        public BranchRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
