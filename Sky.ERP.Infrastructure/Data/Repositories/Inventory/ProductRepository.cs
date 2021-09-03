using Sky.ERP.Domain.Entities.Inventory;

namespace Sky.ERP.Infrastructure.Data.Repositories.Inventory
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
