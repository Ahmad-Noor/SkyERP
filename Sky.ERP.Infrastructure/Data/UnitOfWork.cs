using Sky.ERP.Domain.Base;
using Sky.ERP.Domain.Interfaces;
using Sky.ERP.Domain.Entities.GL;
using Sky.ERP.Domain.Entities.HR;
using Microsoft.Extensions.Logging;
using Sky.ERP.Domain.Entities.Sales;
using Sky.ERP.Domain.Entities.Common;
using Sky.ERP.Domain.Entities.Inventory;
using Sky.ERP.Infrastructure.Data.Repositories;
using Sky.ERP.Infrastructure.Data.Repositories.GL;
using Sky.ERP.Infrastructure.Data.Repositories.HR;
using Sky.ERP.Infrastructure.Data.Repositories.Sales;
using Sky.ERP.Infrastructure.Data.Repositories.Common;
using Sky.ERP.Infrastructure.Data.Repositories.Inventory;
using Sky.ERP.Domain.Entities.POS;
using Sky.ERP.Infrastructure.Data.Repositories.POS;

namespace Sky.ERP.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork, IAsyncDisposable
    {
        private readonly SkyERPDBContext dbContext;
        private readonly ILogger<UnitOfWork> logger;

        public UnitOfWork(IDatabaseConnectionString databaseConnectionString, ILogger<UnitOfWork> logger)
        {
            dbContext = new SkyERPDBContext(databaseConnectionString.ConnectionString);
            this.logger = logger;
        } 

        private IBranchRepository branchRepository;
        private IAddressRepository addressRepository;
        private ICurrencyRepository currencyRepository;
        private IGLChartRepository gLChartRepository;
        private IDepartmentRepository departmentRepository;
        private IEmployeeRepository employeeRepository;
        private IProductRepository productRepository;
        private IProductSizeRepository productSizeRepository;
        private ICustomerRepository customerRepository;
        private IProductMaterialRepository productMaterialRepository;
        private IProductUnitRepository productUnitRepository;
        private ISizeRepository sizeRepository;
        private IUnitRepository unitRepository;
        private IFloorRepository floorRepository;
        private ITableRepository tableRepository;
        private IKitchenRepository kitchenRepository;

        public IBranchRepository BranchRepository => branchRepository ??= new BranchRepository(dbContext);
        public IAddressRepository AddressRepository => addressRepository ??= new AddressRepository(dbContext);
        public ICurrencyRepository CurrencyRepository => currencyRepository ??= new CurrencyRepository(dbContext);
        public IGLChartRepository GLChartRepository => gLChartRepository ??= new GLChartRepository(dbContext);
        public IDepartmentRepository DepartmentRepository => departmentRepository ??= new DepartmentRepository(dbContext);
        public IEmployeeRepository EmployeeRepository => employeeRepository ??= new EmployeeRepository(dbContext);
        public IProductRepository ProductRepository => productRepository ??= new ProductRepository(dbContext);
        public IProductSizeRepository ProductSizeRepository => productSizeRepository ??= new ProductSizeRepository(dbContext);
        public ICustomerRepository CustomerRepository => customerRepository ??= new CustomerRepository(dbContext);
        public IProductMaterialRepository ProductMaterialRepository => productMaterialRepository ??= new ProductMaterialRepository(dbContext);
        public IProductUnitRepository ProductUnitRepository => productUnitRepository ??= new ProductUnitRepository(dbContext);
        public ISizeRepository SizeRepository => sizeRepository ??= new SizeRepository(dbContext);
        public IUnitRepository UnitRepository => unitRepository ??= new UnitRepository(dbContext);
        public IFloorRepository FloorRepository => floorRepository ??= new FloorRepository(dbContext);
        public ITableRepository TableRepository => tableRepository ??= new TableRepository(dbContext);
        public IKitchenRepository KitchenRepository => kitchenRepository ??= new KitchenRepository(dbContext);


        public IAsyncRepository<T> AsyncRepository<T>() where T : Entity
        {
            return new RepositoryBase<T>(dbContext);
        }

        public Task<int> SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// No matter an exception has been raised or not, 
        /// this method always will dispose the DbContext 
        /// </summary>
        /// <returns></returns>
        ValueTask IAsyncDisposable.DisposeAsync()
        {
            return dbContext.DisposeAsync();
        } 
    }
}