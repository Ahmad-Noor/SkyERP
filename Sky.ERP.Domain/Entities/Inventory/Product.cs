using Sky.ERP.Domain.Base; 

namespace Sky.ERP.Domain.Entities.Inventory
{
    public class Product : Entity, IAggregateRoot
    {  
        public long Id { get;  set; }
        public string? Code { get;  set; }
        public string? Name { get;  set; }
        public string? Description { get;  set; }
        public string? ImageURL { get;  set; }
        public int CategoryId { get;  set; }
        public int KitchenId { get;  set; }
        public float Price { get;  set; }
        public bool IsKitchenPrint { get;  set; }
        public int SortId { get;  set; }
        public int ColorArgb { get;  set; }
        public int ProductType { get;  set; }
        public int Barcode { get;  set; }
        public int DefaultSupplier { get;  set; }
        public bool? HasSeries { get;  set; }
        public bool? IsHasColors { get;  set; }
        public bool? IsHasSizes { get;  set; }
        public bool? IsHasExpirDate { get;  set; }
        public bool? IsHasWarranty { get;  set; }
        public bool? IsActive { get;  set; }
        public int DemandLimit { get;  set; }
        public int MonthlySalesTarget { get;  set; }
        public int IntervalRecession { get;  set; }
        public int HighestRate { get;  set; }
        public int AttentionExpirDate { get;  set; }

 
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}