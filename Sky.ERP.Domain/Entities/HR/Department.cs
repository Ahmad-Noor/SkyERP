using Sky.ERP.Domain.Base;

namespace Sky.ERP.Domain.Entities.HR
{
    public class Department : Entity, IAggregateRoot
    { 
        public int Id { get;  set; }
        public string Code { get;  set; }
        public string Name { get;  set; }
        public string? Description { get;  set; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}