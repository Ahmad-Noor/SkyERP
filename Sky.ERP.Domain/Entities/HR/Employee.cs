using Sky.ERP.Domain.Base;
namespace Sky.ERP.Domain.Entities.HR;

public class Employee : Entity, IAggregateRoot
{ 

    public long Id { get;  set; }
    public string Code { get;  set; }
    public string FirstName { get;  set; }
    public string? LastName { get;  set; }
    public string? FatherName { get;  set; }
    public string? MotherName { get;  set; }
    public string ImageURL { get;  set; }
    public string? MachineCode { get;  set; }
    public int? Gender { get;  set; }
    public int? ReligionID { get;  set; }
    public DateTime? DateofBirth { get;  set; }
    public string? PlaceOfBirth { get;  set; }
    public int? MilitaryService { get;  set; }
    public int? MaterialState { get;  set; }
    public long? AddressId { get;  set; }
    public long? ContactId { get;  set; }
    public long? JobId { get;  set; }
    public long? DepartmentId { get;  set; }
    public long? ManagementId { get;  set; }
    public long? WorkStatusID { get;  set; }
    public long? ManagerId { get;  set; }
     
    protected override IEnumerable<object> GetIdentityComponents()
    {
        yield return Id;
    }
}