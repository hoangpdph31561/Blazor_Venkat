using EmployeeManagerment.API.Configurations;
using EmployeeManagerment.API.DataSeeding;
using Microsoft.EntityFrameworkCore;
using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.API.DBContext
{
    public class EmployeeManagermentDBContext : DbContext
    {
        public EmployeeManagermentDBContext(DbContextOptions<EmployeeManagermentDBContext> options) : base(options)
        {
            
        }
        public DbSet<Employee>  Employees { get; set; }
        public DbSet<Deparment> Deparments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DeparmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.Seed();
        }
    }
}
