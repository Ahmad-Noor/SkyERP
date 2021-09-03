using Sky.ERP.Domain.Base;
using Sky.ERP.Domain.Entities.GL;
using Sky.ERP.Domain.Entities.HR;
using Sky.ERP.Domain.Entities.Sales;
using Sky.ERP.Domain.Entities.Common;
using Sky.ERP.Domain.Entities.Inventory;
using System.Threading.Tasks;
using Sky.ERP.Domain.Entities.POS;

namespace Sky.ERP.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        // Common 
        IBranchRepository BranchRepository { get; }
        IAddressRepository AddressRepository { get; }
        ICurrencyRepository CurrencyRepository { get; }


        // GL 
        IGLChartRepository GLChartRepository { get; }



        // HR
        IDepartmentRepository DepartmentRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }


        // Inventory
        IProductRepository ProductRepository { get; }
        IProductSizeRepository ProductSizeRepository { get; }
        IProductMaterialRepository ProductMaterialRepository { get; }
        IProductUnitRepository ProductUnitRepository { get; }
        ISizeRepository SizeRepository { get; }
        IUnitRepository UnitRepository { get; }


        // Sales
        ICustomerRepository CustomerRepository { get; }


        // POS
        IFloorRepository FloorRepository { get; } 
        ITableRepository TableRepository { get; }
        IKitchenRepository KitchenRepository { get; }





        Task<int> SaveChangesAsync();

        IAsyncRepository<T> AsyncRepository<T>() where T : Entity;
    }
}
