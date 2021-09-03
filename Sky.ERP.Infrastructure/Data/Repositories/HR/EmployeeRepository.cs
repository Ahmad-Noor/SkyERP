using Sky.ERP.Domain.Entities.HR;

namespace Sky.ERP.Infrastructure.Data.Repositories.HR
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
