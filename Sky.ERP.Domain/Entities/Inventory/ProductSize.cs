using Sky.ERP.Domain.Base; 

namespace Sky.ERP.Domain.Entities.Inventory
{
    public class ProductSize : Entity, IAggregateRoot
    { 
        public long Id { get;  set; } 
        public long ProductId { get;  set; }
        public long SizeId { get;  set; }
        public float Price { get;  set; }
 
 

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}