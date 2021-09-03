using Sky.ERP.Domain.Entities.GL;

namespace Sky.ERP.Infrastructure.Data.Repositories.GL
{
    public class GLChartRepository : RepositoryBase<GLChart>, IGLChartRepository
    {
        public GLChartRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
