using Sky.ERP.Domain.Base;

namespace Sky.ERP.Domain.Entities.Common
{
    public class Address : Entity, IAggregateRoot
    { 
        public long Id { get;  set; }
        public string Street { get;  set; }
        public string? Line2 { get;  set; }
        public long? CityId { get;  set; }
        public long? StateId { get;  set; }
        public string? PostalCode { get;  set; }//15 
        public bool? IsPhysical { get;  set; }
        public bool? IsShipping { get;  set; }
        public bool? IsBilling { get;  set; }
        public bool? IsActive { get;  set; }

 

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}