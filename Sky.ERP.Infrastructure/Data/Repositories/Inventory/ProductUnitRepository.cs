using Sky.ERP.Domain.Entities.Inventory;

namespace Sky.ERP.Infrastructure.Data.Repositories.Inventory
{
    public class ProductUnitRepository : RepositoryBase<ProductUnit>, IProductUnitRepository
    {
        public ProductUnitRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
