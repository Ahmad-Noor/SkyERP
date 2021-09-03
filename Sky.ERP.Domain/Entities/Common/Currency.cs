using Sky.ERP.Domain.Base; 

namespace Sky.ERP.Domain.Entities.Common
{
    public class Currency : Entity, IAggregateRoot
    { 
        public long Id { get;  set; }
        public string Code { get;  set; }
        public string Name { get;  set; }
        public float? Rate { get;  set; }
        public string? Symbol { get;  set; }//5

         

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}