using Sky.ERP.Domain.Base; 

namespace Sky.ERP.Domain.Entities.POS
{
    public class Kitchen : Entity, IAggregateRoot
    { 
        public long Id { get;  set; }
        public string Code { get;  set; }
        public string Name { get;  set; }  
        public bool? IsHavePrinter { get;  set; }   
        public bool? IsHaveScreen { get;  set; }  

  
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}