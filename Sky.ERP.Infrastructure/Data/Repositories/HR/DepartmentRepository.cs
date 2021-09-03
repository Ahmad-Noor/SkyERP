using Sky.ERP.Domain.Entities.HR;

namespace Sky.ERP.Infrastructure.Data.Repositories.HR
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
