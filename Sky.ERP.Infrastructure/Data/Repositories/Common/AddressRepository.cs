using Sky.ERP.Domain.Entities.Common;

namespace Sky.ERP.Infrastructure.Data.Repositories.Common
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
