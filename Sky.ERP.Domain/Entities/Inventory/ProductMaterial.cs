using Sky.ERP.Domain.Base;

namespace Sky.ERP.Domain.Entities.Inventory
{
    public class ProductMaterial : Entity, IAggregateRoot
    { 
        public long Id { get;  set; }
        public long ProductId { get;  set; }
        public long ProductMaterialId { get;  set; }
        public float Quantity { get;  set; }
 

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}