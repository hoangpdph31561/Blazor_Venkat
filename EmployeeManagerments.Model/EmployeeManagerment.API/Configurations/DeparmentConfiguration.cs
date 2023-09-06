using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.API.Configurations
{
    public class DeparmentConfiguration : IEntityTypeConfiguration<Deparment>
    {
        public void Configure(EntityTypeBuilder<Deparment> builder)
        {
            builder.ToTable("Deparments");
            builder.HasKey(x => x.DeparmentId);
            builder.Property( x => x.DeparmentId).UseIdentityColumn();
            builder.Property(x => x.DeparmentName).HasMaxLength(200).IsRequired(true);
        }
    }
}
