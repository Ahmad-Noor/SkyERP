using Sky.ERP.Domain.Entities.Inventory;

namespace Sky.ERP.Infrastructure.Data.Repositories.Inventory
{
    public class ProductSizeRepository : RepositoryBase<ProductSize>, IProductSizeRepository
    {
        public ProductSizeRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
