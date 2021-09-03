using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sky.ERP.Domain.Entities.HR;

namespace Sky.ERP.Infrastructure.Data.EntitiesConfig.HR
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Code).HasMaxLength(10);
            builder.Property(t => t.FirstName).HasMaxLength(150);
            builder.Property(t => t.LastName).HasMaxLength(150);
            builder.Property(t => t.FatherName).HasMaxLength(150);
            builder.Property(t => t.MotherName).HasMaxLength(150);
            builder.Property(t => t.ImageURL).HasMaxLength(500);
            builder.Property(t => t.MachineCode).HasMaxLength(10);
            builder.Property(t => t.PlaceOfBirth).HasMaxLength(150);
        }
    }
}
