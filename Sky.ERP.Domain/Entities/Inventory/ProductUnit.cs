using Sky.ERP.Domain.Base; 

namespace Sky.ERP.Domain.Entities.Inventory
{
    public class ProductUnit : Entity, IAggregateRoot
    { 
        public long Id { get;  set; }
        public long ProductId { get;  set; }
        public long UnitId { get;  set; }
        public float? Quantity { get;  set; }
        public bool? IsDefault { get;  set; }
        public float? PurchasingPrice { get;  set; } 
        public float? SellingPrice { get;  set; }

   
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}