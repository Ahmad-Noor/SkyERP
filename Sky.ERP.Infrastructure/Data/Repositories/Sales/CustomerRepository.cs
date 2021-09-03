using Sky.ERP.Domain.Entities.Sales;

namespace Sky.ERP.Infrastructure.Data.Repositories.Sales
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
