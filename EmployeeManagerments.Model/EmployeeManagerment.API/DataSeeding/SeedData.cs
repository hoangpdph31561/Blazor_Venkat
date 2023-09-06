using Microsoft.EntityFrameworkCore;
using SelfLearn_Blazor_kudvenkat.Entities;
using SelfLearn_Blazor_kudvenkat.Enum;

namespace EmployeeManagerment.API.DataSeeding
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deparment>().HasData(
                new Deparment
                {
                    DeparmentId = 1,
                    DeparmentName = "IT"
                },
                new Deparment
                {
                    DeparmentId = 2,
                    DeparmentName = "HR"
                },
                new Deparment
                {
                    DeparmentId = 3,
                    DeparmentName = "Payroll"
                },
                new Deparment
                {
                    DeparmentId = 4,
                    DeparmentName = "Admin"
                }) ;
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Hastings",
                    Email = "David@pragimtech.com",
                    DateOfBirth = new DateTime(1980, 10, 5),
                    Gender = Gender.Male,
                    DeparmentId = 1,
                    PhotoPath = "images/z4588458814052_472230aad824892dcc3c25f7e6fddfbc.jpg"
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Sam",
                    LastName = "Galloway",
                    Email = "Sam@pragimtech.com",
                    DateOfBirth = new DateTime(1981, 12, 22),
                    Gender = Gender.Male,
                    DeparmentId = 2,
                    PhotoPath = "images/z4588458814052_472230aad824892dcc3c25f7e6fddfbc.jpg"
                },
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Mary",
                    LastName = "Smith",
                    Email = "mary@pragimtech.com",
                    DateOfBirth = new DateTime(1979, 11, 11),
                    Gender = Gender.Female,
                    DeparmentId = 1,
                    PhotoPath = "images/z4588458814052_472230aad824892dcc3c25f7e6fddfbc.jpg"
                },
                new Employee
                {
                    EmployeeId = 4,
                    FirstName = "Sara",
                    LastName = "Longway",
                    Email = "sara@pragimtech.com",
                    DateOfBirth = new DateTime(1982, 9, 23),
                    Gender = Gender.Female,
                    DeparmentId = 3,
                    PhotoPath = "images/z4588458814052_472230aad824892dcc3c25f7e6fddfbc.jpg"
                });
        }
    }
}
