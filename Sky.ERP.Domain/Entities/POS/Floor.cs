using Sky.ERP.Domain.Base; 

namespace Sky.ERP.Domain.Entities.POS
{
    public class Floor : Entity, IAggregateRoot
    { 
        public long Id { get;  set; }
        public string Code { get;  set; }
        public string Name { get;  set; } 
        public string ImageURL { get;  set; } 

  
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}