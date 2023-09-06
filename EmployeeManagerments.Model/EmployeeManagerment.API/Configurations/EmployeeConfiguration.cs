using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.API.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(x => x.EmployeeId);
            builder.Property(x => x.EmployeeId).UseIdentityColumn();
            builder.Property(x => x.FirstName).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.PhotoPath).HasMaxLength(200).IsRequired(false);
            builder.HasOne(x => x.Deparment).WithMany(x => x.Employees).HasForeignKey(x => x.DeparmentId);
        }
    }
}
