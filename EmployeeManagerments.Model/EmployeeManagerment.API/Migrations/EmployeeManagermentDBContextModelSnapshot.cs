﻿// <auto-generated />
using System;
using EmployeeManagerment.API.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagerment.API.Migrations
{
    [DbContext(typeof(EmployeeManagermentDBContext))]
    partial class EmployeeManagermentDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SelfLearn_Blazor_kudvenkat.Entities.Deparment", b =>
                {
                    b.Property<int>("DeparmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeparmentId"), 1L, 1);

                    b.Property<string>("DeparmentName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("DeparmentId");

                    b.ToTable("Deparments", (string)null);

                    b.HasData(
                        new
                        {
                            DeparmentId = 1,
                            DeparmentName = "IT"
                        },
                        new
                        {
                            DeparmentId = 2,
                            DeparmentName = "HR"
                        },
                        new
                        {
                            DeparmentId = 3,
                            DeparmentName = "Payroll"
                        },
                        new
                        {
                            DeparmentId = 4,
                            DeparmentName = "Admin"
                        });
                });

            modelBuilder.Entity("SelfLearn_Blazor_kudvenkat.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeparmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DeparmentId");

                    b.ToTable("Employees", (string)null);

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfBirth = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeparmentId = 1,
                            Email = "David@pragimtech.com",
                            FirstName = "John",
                            Gender = 0,
                            LastName = "Hastings",
                            PhotoPath = "images/z4588458814052_472230aad824892dcc3c25f7e6fddfbc.jpg"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfBirth = new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeparmentId = 2,
                            Email = "Sam@pragimtech.com",
                            FirstName = "Sam",
                            Gender = 0,
                            LastName = "Galloway",
                            PhotoPath = "images/z4588458814052_472230aad824892dcc3c25f7e6fddfbc.jpg"
                        },
                        new
                        {
                            EmployeeId = 3,
                            DateOfBirth = new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeparmentId = 1,
                            Email = "mary@pragimtech.com",
                            FirstName = "Mary",
                            Gender = 1,
                            LastName = "Smith",
                            PhotoPath = "images/z4588458814052_472230aad824892dcc3c25f7e6fddfbc.jpg"
                        },
                        new
                        {
                            EmployeeId = 4,
                            DateOfBirth = new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeparmentId = 3,
                            Email = "sara@pragimtech.com",
                            FirstName = "Sara",
                            Gender = 1,
                            LastName = "Longway",
                            PhotoPath = "images/z4588458814052_472230aad824892dcc3c25f7e6fddfbc.jpg"
                        });
                });

            modelBuilder.Entity("SelfLearn_Blazor_kudvenkat.Entities.Employee", b =>
                {
                    b.HasOne("SelfLearn_Blazor_kudvenkat.Entities.Deparment", "Deparment")
                        .WithMany("Employees")
                        .HasForeignKey("DeparmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deparment");
                });

            modelBuilder.Entity("SelfLearn_Blazor_kudvenkat.Entities.Deparment", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
