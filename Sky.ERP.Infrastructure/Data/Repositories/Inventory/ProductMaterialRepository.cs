using Sky.ERP.Domain.Entities.Inventory;

namespace Sky.ERP.Infrastructure.Data.Repositories.Inventory
{
    public class ProductMaterialRepository : RepositoryBase<ProductMaterial>, IProductMaterialRepository
    {
        public ProductMaterialRepository(SkyERPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
