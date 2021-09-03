using Sky.ERP.Domain.Base;

namespace Sky.ERP.Domain.Entities.GL
{
    public class GLChart : Entity, IAggregateRoot
    { 
        public long Id { get;  set; }
        public string Code { get;  set; }//150
        public long Name { get;  set; }
        public long ParentId { get;  set; }
        public int AccountOrder { get;  set; }
        public long FinalAccountId { get;  set; }
        public long CurrencyId { get;  set; }
        public int AccountNature { get;  set; }
        public int AccountType { get;  set; }

 
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}